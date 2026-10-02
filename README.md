# TechRent - Vállalati IT Eszközkölcsönző Rendszer

Ez a projekt a **Szoftverfejlesztő és -tesztelő (5 0613 12 03)** szakmai vizsgára készült. 
A TechRent egy többrétegű (multi-tier) belső vállalati informatikai rendszer, amelynek célja a cégek IT eszközparkjának (laptopok, tesztkészülékek, projektorok) modern, nyomon követhető és biztonságos kezelése.

## 🏗️ Technológiai Stack
*   **Adatbázis:** MySQL (Laragon)
*   **Backend:** C# ASP.NET Core Web API (RESTful architektúra)
*   **Asztali Kliens:** C# Windows Forms (.NET Framework)
*   **Webes Kliens:** HTML5, CSS3, Vanilla JavaScript (Fetch API)

## 📁 Mappaszerkezet
A projekt az alábbi logikai részekre van bontva:
*   `/Backend_WinForms` - Tartalmazza a C# Web API és a Windows Forms asztali alkalmazás Visual Studio projektfájljait (`.sln`).
*   `/Frontend_Web` - A dolgozói felület weblapjának forráskódja (VS Code).
*   `/Adatbazis` - A MySQL adatbázis sémáját és tesztadatait tartalmazó kimentett `.sql` fájl.
*   `Szakmai Vizsgaanyag_2.md` - Részletes projektterv, feladatmegosztás és technikai specifikáció.

## 👥 Csapat és Feladatmegosztás
1.  **Backend és Adatbázis:** Adatbázis tervezése, ASP.NET Core API végpontok fejlesztése.
2.  **Asztali Alkalmazás (WinForms):** A rendszergazdai felület kialakítása, API hívások integrálása (`HttpClient`, `System.Text.Json`).
3.  **Webes Frontend:** A reszponzív dolgozói katalógus leprogramozása, AJAX kommunikáció az API-val.

## 🚀 Telepítés és Futtatás (Fejlesztői környezet)

### 1. Adatbázis beállítása
1. Indítsd el a **Laragon**-t (Start All).
2. Nyisd meg a phpMyAdmin-t, és hozz létre egy `TechRent` nevű adatbázist.
3. Importáld be az `/Adatbazis` mappában található `.sql` fájlt.

### 2. Backend és WinForms (Visual Studio)
1. Nyisd meg a `TechRentSolution.sln` fájlt a `/Backend_WinForms` mappából a Visual Studióban.
2. Ellenőrizd a `launchSettings.json` fájlban a kiosztott API portot (pl. `7001`).
3. A *Solution Explorerben* állítsd be a **Multiple startup projects** opciót, hogy az API és a WinForms alkalmazás egyszerre induljon el.
4. Futtasd a projektet (F5).

### 3. Weboldal (VS Code)
1. Nyisd meg a `/Frontend_Web` mappát VS Code-ban.
2. Indítsd el az `index.html` fájlt a böngésződben (ajánlott a *Live Server* kiterjesztés használata).
3. Győződj meg róla, hogy az `app.js` fájlban a megfelelő (Visual Studio által kiosztott) portra hivatkozik a `fetch()` metódus.
