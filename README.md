# دليل التيم — مشروع File Manager (مادة OS)

الريبو ده فيه **الأساس المشترك + نظام الـ Multithreading والـ Mutex** جاهز في `Form1.cs`، عشان كل فرد في التيم يركّز في الوظيفة المطلوبة منه بس ويربطها بالدوال الجاهزة من غير ما يكتب كود Threads أو Synchronization من الصفر.

---

## أولاً: الشروط التقنية الأساسية للمادة (لازم الكل يلتزم بيها)

1. **Multithreading:** أي عملية ملفات (Create, Delete, Search, Read/Write, Copy/Move) **لازم** تشتغل في Background Thread عشان الواجهة متهنجش. (عملية `Open` بس هي اللي على الـ Main Thread).
2. **Thread Synchronization:** ممنوع تعديل العدادات أو الـ Log مباشرة؛ استخدم الدوال الجاهزة المحمية بـ `Mutex`.
3. **Thread-Safe UI Updates:** ممنوع تعدل أي عنصر في الواجهة (`dataGridView1`, `TextBox`, `Label`, ...) من جوه Thread مباشرة! لازم تستخدم `this.BeginInvoke(...)`.
4. **Graphics (GDI+):** استخدام مكتبة `System.Drawing` لرسم مخطط مساحة التخزين.

---

## ثانياً: الدوال والمتغيرات الجاهزة في `Form1.cs` (للاستخدام المباشر)

### 1. متغيرات الحالة الحالية
- `CurrentFolderPath` : مسار الفولدر المفتوح حالياً في الجدول (وقيمته `"This PC"` لو إحنا في الشاشة الرئيسية).
- `SelectedItemPath` : المسار الكامل للملف أو الفولدر اللي المستخدم ضغط عليه في الجدول.

### 2. تشغيل الكود في Thread مستقل (`RunInThread`)
```csharp
RunInThread(() =>
{
    // اكتب كود العملية هنا (Create / Delete / Search / Read / Write)
});
```
> الدالة دي بتعمل Background Thread جديد أوتوماتيك وبتسميه `Thread-1`, `Thread-2`, ... باستخدام `Interlocked.Increment`.

### 3. تسجيل الأحداث في الـ Log (`AddLog`)
```csharp
AddLog("رسالة العملية هنا", Color.Green); // أو Color.Red في حالة الخطأ
```
> محمية بـ `Mutex` و `BeginInvoke`، وبتطبع اسم الـ Thread والوقت تلقائياً.

### 4. تحديث عدادات العمليات (`UpdateStats`)
```csharp
UpdateStats("Create"); // بتزود OpCount و NumOfCreated
UpdateStats("Delete"); // بتزود OpCount و NumOfDeleted
// أي اسم تاني بيزود إجمالي العمليات (OpCount) فقط
```
> محمية بـ `Mutex` وبتحدث الليبلز بأمان، **التزم بنفس الـ Spelling** (`"Create"` و `"Delete"`).

### 5. تحديث شريط التقدم (`UpdateProgress`)
```csharp
UpdateProgress("Deleting file...", 50);
```
> بتحدث النص، الـ `progressBar` (من `0` لـ `100`)، النسبة المئوية، واسم الـ Thread النشط عبر `BeginInvoke`.

### 6. تحديث الجدول بعد أي تعديل (`LoadDirectory`)
⚠️ **تنبيه مهم:** دالة `LoadDirectory` بتعدل على `dataGridView1` مباشرة، فلو هتناديها من جوه `RunInThread` **لازم** تغلفها بـ `BeginInvoke`:
```csharp
if (CurrentFolderPath != "This PC" && Directory.Exists(CurrentFolderPath))
{
    this.BeginInvoke(new Action(() => LoadDirectory(CurrentFolderPath)));
}
```

---

## ثالثاً: توزيعة المهام على التيم

### اللي خلص بالفعل (الأساس المشترك):
- شاشة `This PC` وعرض الدرايفات + أزرار الوصول السريع + `Browse` + `LoadDirectory`.
- عرض تفاصيل الملف/الفولدر (`ItemInfo<T>`).
- `Open File / Folder` على الـ Main Thread.
- `Copy / Move File` على Background Thread مع `FileStream` (80 KB Buffer) وشريط التقدم.
- البنية التحتية: `RunInThread`, `UpdateStats`, `AddLog`, `UpdateProgress`.

### المطلوب من باقي التيم:

- **الفرد الأول — `Create File` & `Create Folder`**
  - التأكد إن `CurrentFolderPath != "This PC"` قبل الإنشاء.
  - تنفيذ الإنشاء جوه `RunInThread(...)`.
  - استدعاء `UpdateStats("Create")` و `AddLog(...)` ثم تحديث الجدول بـ `BeginInvoke(() => LoadDirectory(CurrentFolderPath))`.

- **الفرد الثاني — `Clear Log` & `Graphics Representation (GDI+)`**
  - **Clear Log:** تفريغ `LogBox.Clear()`.
  - **Graphics:** رسم مخطط بياني يوضح المساحة المستخدمة والمتاحة للدرايف باستخدام `System.Drawing` (GDI+).

- **الفرد الثالث — `Delete File / Folder` & `Get Drive Info`**
  - **Delete:** التحقق من `SelectedItemPath` وتأكيد المستخدم (`MessageBox`) قبل الحذف، ثم الحذف جوه `RunInThread(...)`، وبعدها `UpdateStats("Delete")` و `AddLog(...)` وتحديث الجدول بـ `BeginInvoke`.
  - **Get Drive Info:** جلب تفاصيل البارتيشن من `DriveInfo` (المساحة الكلية، المتاحة، المستخدمة، الـ Format، إلخ) وعرضها في الواجهة.

- **الفرد الرابع — `Search Files` & `Read / Write File`**
  - **Search Files:** البحث عن الملفات جوه `RunInThread(...)` وعرض النتائج في الواجهة عبر `BeginInvoke`.
  - **Read / Write File:** قراءة وكتابة محتوى الملفات النصية في Threads مستقلة مع تحديث الواجهة بـ `BeginInvoke` وتسجيل العملية بـ `AddLog`.

---

## قواعد سريعة قبل ما ترفع على GitHub (Push)
1. اعمل Pull قبل ما تبدأ شغل عشان تتجنب الـ Merge Conflicts في `Form1.Designer.cs`.
2. تأكد إن مفيش أي `Control` بيتعدل من جوه Background Thread من غير `BeginInvoke` (هيعمل `Cross-thread operation not valid`).
3. جرّب العملية على ملف كبير أو فولدر فيه ملفات كتير واتأكد إن الواجهة مش بتهنج وإن الـ `LogBox` والعدادات بيتحدثوا صح.
