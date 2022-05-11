---
cover: >-
  https://images.unsplash.com/photo-1511497584788-876760111969?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=3432&q=80
coverY: 0
---

# elmah - לוג שגיאות

כל השגיאות הלא מטופלות מגיעות ללוג שגיאות בדף elmah.axd, ניתן לגשת אל הדף הזה רק מ-localhost.

לדוגמה בשביל לצפות בלוג שגיאות עבור אפליקציית mmReutYom בשרת 31, צריך להתחבר בRDP לשרת 31 ושם להיכנס לכתובת:

{% embed url="http://localhost/mmReutYom/elmah.axd" %}

דף השגיאות צריך להיראות כך:

&#x20;<img src="../.gitbook/assets/image (6).png" alt="" data-size="original">

רק עם יותר שגיאות (בתקווה שלא, אבל זה המצב)

לחיצה על details תציג על המסך פרטים מלאים השגיאה, באיזו קובץ היא נוצרה, השורת קוד שהובילה אליה, פרטים על הבקשת HTTP, ותגיות שרת ומשתני סביבה רלוונטיים ושאינם רלוונטיים.
