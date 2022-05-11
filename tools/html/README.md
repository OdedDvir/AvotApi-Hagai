---
description: צורת השימוש
---

# טפסי HTML

הטפסים הרפואיים הם טפסים שניתן להציג למשתמש למלא, הם מקבלים את התבנית שלהם מהמסד נתונים

בצד לקוח ישנן שתי דרכים להציג טופס למשתמש.

האפשרות הראשונה:

&#x20;באמצעות הפקד AjaxFormView.ascx של ASP.NET, אפשר למצוא אותו תחת התיקייה Controls בפרוייקט, בצורה הזו אפשר לכלול את הטופס בתוך דף של ASP.NET

האפשרות השניה:

קריאה לפונקציית Javascript שמוכללת בתוך כל הדפים בשם getFormHtml, היא קיימת בכמה וריאנטים, בצורה הזו אפשר להציג כל טופס בתוך כל דף באמצעות Javascript.

תבנית הטופס במסד נתונים:

בשביל לבנות את הטופס צריכות לחזור מהפרוצדורה לפחות שתי טבלאות, הטבלה הראשונה שמהווה את הטמפלייט, התבנית, עבור הטופס (הרחבה בהמשך), והטבלה השניה שמכילה את המידע שיוצג למשתמש בתוך הטופס.

הדרך הכי קלה להתחיל לבנות טופס היא ע"י עריכה של טמפלייט קיים,&#x20;

לבצע את השאילתא הבאה כדי לקבל את הטמפלייט של הפרוצדורה pr\_FormTest:

`pr_insf pr_FormTest`

התוצאה צריכה להיראות כך:

```
delete from tblFormViewTemplate where key1='pr_FormTest'
INSERT INTO [tblFormViewTemplate] ([Key1],[ordId],[FieldCap],[SizeCont],[FieldName],[ControlType],[bLock],[bNoBreakCell],[Param1],[Param2],[ValidatorStatus],[Param3],[ParentField],[InputSize],[AllowView],[AllowUpdate],[Default],[InputSize2],[ShowMode])VALUES('pr_FormTest',-30,'rich',400,'rich','rich',0,0,'','','m','','',6,'','','2',0,'')
INSERT INTO [tblFormViewTemplate] ([Key1],[ordId],[FieldCap],[SizeCont],[FieldName],[ControlType],[bLock],[bNoBreakCell],[Param1],[Param2],[ValidatorStatus],[Param3],[ParentField],[InputSize],[AllowView],[AllowUpdate],[Default],[InputSize2],[ShowMode])VALUES('pr_FormTest',-20,'tableproc',400,'','TableProc',0,0,'<div class="form-row"><label><b>clientid:</b> #clientid#, <b>uid:</b> #uid#, <b>lang:</b> #lang#</label></div>','','m','pr_proctabletest','',6,'',NULL,'',0,'')
...
```

בעצם הפרוצדורה prinsf מייצרת טמפלייט עבור טופס לפי "מפתח", אשר במקרה הזה הוא prFormTest, עלינו ליצור מפתח משלנו, לכן את כל המקומות שמופיעה בהם המילה prFormTest במפתח החדש אותו אנחנו רוצים ליצור, לשם הסדר נבחר את שם המפתח כפי שם הפרוצדורה שנרצה אח"כ לקרוא לה ע"מ לייצר את הטופס, למשל אם אנחנו מעוניינים ליצור פרוצדורה שמציגה טופס יצירת משתמש חדש, ונרצה לקרוא לה pr\_NewUserForm, אז גם למפתח אנחנו נקרא pr\_NewUserForm

גשו לקליינט&#x20;

TODO: הפרמטרים שהפקד AjaxFormView.ascx מקבל

TODO: הפרמטרים שהפונקציית ג'אווהסקריפט מקבלת
