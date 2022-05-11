---
description: >-
  הפונקציה הזאת זהה בדרך הפעולה שלה לgetDatatable, רק מחזירה מספר טבלאות במקום
  טבלה אחת.
---

# getDataSet

בשביל פרמטרים ודרך ההרצה - יש לעיין בערך [getDatatable](getdatatable.md)

ההבדל ביניהם הוא רק באובייקט שחוזר, ניתן לקבל כמה טבלאות בצורה הזו:

```
[
    [
        {Hour: '00:00', Date: '2022-03-23'},
        {Hour: '01:00', Date: '2022-03-23'},
        ...
        {Hour: '23:00', Date: '2022-03-23'},                
    ],
    [
        {Column1: 'value1', Column2: 'value2'},
        {Column1: 'value3', Column2: 'value4'},
        ...
        {Column1: 'value99', Column2: 'value100'},
    ]
]
```

דוגמה לצורת שימוש עם הטבלות
