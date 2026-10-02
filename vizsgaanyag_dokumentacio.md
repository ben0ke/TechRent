# Projektterv és Technikai Specifikáció: "TechRent" Vállalati Eszközkölcsönző

**Készült a Szoftverfejlesztő és -tesztelő (5 0613 12 03) szakmai vizsgához**

## 1. A Projekt Célja és Bemutatása
A "TechRent" egy többrétegű (multi-tier) belső vállalati informatikai rendszer, amelynek célja a cégek IT eszközparkjának (laptopok, tesztkészülékek, projektorok) modern, nyomon követhető és biztonságos kezelése. A rendszer kiváltja az elavult, papíralapú vagy táblázatkezelős nyilvántartásokat. A szoftver egy központi RESTful API-n keresztül biztosítja az adatáramlást egy reszponzív dolgozói weboldal és egy rendszergazdai natív asztali alkalmazás (Windows Forms) között.

## 2. Feladatmegosztás (3 fős fejlesztői csapat)
A fejlesztés a modern ipari standardoknak megfelelően, verziókezelő (Git/GitHub) használatával történik, a feladatokat az alábbiak szerint bontottuk szét:

*   **1. Csapattag (Backend és Adatbázis szakértő):** Felelős a MySQL relációs adatbázis megtervezéséért (táblák, kapcsolatok) és a C# ASP.NET Core Web API elkészítéséért. Ő építi ki a végpontokat és az Entity Framework kapcsolatot a Laragon szerveren futó adatbázissal.
*   **2. Csapattag (Asztali Kliens fejlesztő):** A rendszergazdáknak szánt natív C# Windows Forms alkalmazás fejlesztéséért felel. Feladata az API végpontok integrálása `HttpClient` és `System.Text.Json` használatával, valamint egy ergonómikus, modern, dinamikusan méreteződő asztali felhasználói felület (GUI) kialakítása.
*   **3. Csapattag (Webes Frontend fejlesztő):** A dolgozói felület kialakításáért felel HTML5, CSS3 és Vanilla JavaScript segítségével. Feladata egy reszponzív, böngészőből elérhető eszköz-katalógus létrehozása, amely AJAX (Fetch API) hívásokkal kommunikál a backenddel.

## 3. Architektúra és Technológiai Döntések
A vizsgakövetelmények maradéktalan teljesítése érdekében a következő műszaki alapelveket rögzítettük a tervezés során:

*   **Háromrétegű (3-Tier) Architektúra:** A kliensek (WinForms és HTML/JS) biztonsági okokból sosem kommunikálnak közvetlenül az adatbázissal. A kommunikáció kizárólag a C# ASP.NET Core RESTful API-n keresztül történik, szabványos JSON formátumban.
*   **Hálózati Portok Logikai Elkülönítése:** 
    *   Az adatbázis (Laragon MySQL) a belső, védett **3306**-os porton fut.
    *   Az API egy dedikált porton publikálja a szolgáltatásait (pl. a Visual Studio által kiosztott 7001-es porton). A kliensek kizárólag ezt a portot látják és ezen keresztül küldik a HTTP kéréseket.
*   **Asztali Kliens (WinForms):** A rendszergazdai szoftver fejlesztéséhez a hagyományos .NET Framework alapú Windows Forms technológiát választottuk. A felület reszponzivitását (Anchor tulajdonságok) és az esztétikus megjelenítést egyedi kódolással oldottuk meg. Az API válaszok feldolgozásához a modern, aszinkron `System.Text.Json` csomagot integráltuk.
*   **Adatbázis Kezelés:** Az elkészült MySQL adatbázisról a vizsga végén export fájl (dump) és adatbázismodell-diagram is készül a követelményeknek megfelelően.

## 4. Minőségbiztosítás és Projektmenedzsment
*   **Verziókezelés:** A forráskódot egy közös GitHub repository-ban tároljuk, ami biztosítja a párhuzamos munkavégzést és a kód biztonsági mentését.
*   **Tesztelés:** A fejlesztési szakasz végén az API végpontokra egységteszteket (Unit teszteket) írunk, a felhasználói felületeken pedig manuális funkcionális teszteket végzünk az adatvalidáció (pl. hibás jelszó, duplikált eszközfelvitel) ellenőrzésére.
*   **Dokumentáció:** A folyamatról API végpont-dokumentációt (Swagger) és részletes felhasználói kézikönyvet készítünk a vizsgabizottság számára.
