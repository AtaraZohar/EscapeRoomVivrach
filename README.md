<div dir="rtl">

# EscapeRoom "ויברח"

מימשנו תפריט התחלה שלאחר לחיצה על התחל משחק הוא עובר לאפשרות לחיצה על מספר סיפורי תנ"ך שונים


![](gitHubPicture/1.jpg)

כדי לממש כל אחד המלחצנים שמנו בקוד הבא את כל הפונקציות של כל כפתור ולסצנה שהוא אמור לעבור אליה ובתוך האובייקט של כל
כפתור קישרנו לכל כפתור את הפונקציה המתאימה לו

[playMenu.cs](Assets/scripts/playMenu.cs)

התחלנו לממש מבין המשחקים את סיפור תיבת נוח- לאחר שלוחצים על תיבת נוח מועברים לעמוד שבו מסופר בקצרה על הסיפור 

![](gitHubPicture/2.png)

גם כאן השתמשנו באותו קוד כדי להיכנס לסצנה של תחילת המשחק

 מועברים לדף הראשון במשחק 
מבין כל החידות מימשנו את החידה עם קורות העץ והמנעול  כאשר לוחצים על המנעול מועברים לדף חידה נוסף שאותו צריך לפתור כדי לפתוח את המנעול.

![](gitHubPicture/3.png)

בדף יש חידה שנוגעת לאורך מידת התיבה ו 2 רמזים (בצורת סימן שאלה) כאשר לוחצים על כל רמז מתגלים 2 תמונות שאמורות לעזור לפתור את החידה.

![](gitHubPicture/4.png)

את המימוש שהרמז יופיע כאשר לוחצים על סימן השאלה ויעלם כאשר מורידים את העכבר מהסימן שאלה עשינו על ידי שימוש בקוד הבא בעצם יש אובייקט של התמונה על המסך אך האובייקט לא מופעל אך חיברנו בקוד את התמונה לפעולה של לחיצה בקנבס של התמונה בתוכנה
ואז כאשר לוחצים פועלת פונקציה שמפעילה את התמונה ושמורידים פונקציה אחת שמסתירה את התמונה שוב.

[clickLock.cs](Assets/scripts/clickLock.cs)
השתמשנו בקוד הזה בשביל כמה דברים נוספים 

רמז ראשון, הפסוק מהתנ"ך שמדבר על אורכי התיבה-

![](gitHubPicture/5.png)

רמז שני שאומר שיש להמיר את המידות מהפסוק (שניתנות באמות)  ולחלק את המידות מתוך הפסוק ב2-

![](gitHubPicture/6.png)

לבסוף רושמים את התוצאה (150 אורך התיבה)

![](gitHubPicture/7.png)

כדי שנוכל ללחוץ על התמונה ואחכ לראות את האפשרות להקליד את הטקסט השתמנו שאותה שיטה כמו ברמזים וזה גם נמצא בקוד הבא בפונקציה 
 showInput()
 [clickLock.cs](Assets/scripts/clickLock.cs)
 
 כדי לבדוק האם צדקנו השתמשנו בקוד הבא ואחרי שהוא רואה כי צדקנו הוא מחליף את תיבת הטקסט בתמונה של וי שמופיעה מעל התמונה של החידה כל זה מופיע הקוד הבא
 
[calculate.cs](Assets/scripts/calculate.cs)
עשינו את הקוד בצורה כזאת שיוכל לשמש לחידות אחרות באותה צורה

ומסומן שצדקנו 😊 

![](gitHubPicture/8.png)

 </div>

