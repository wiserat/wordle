# Videohra v CLI: Wordle – Technické požadavky
* **SSPŠ**
* **Verze 1**
* **Jonáš Tenora**
* **28.9.2024**

## Obsah
1. Historie Dokumentu
2. Úvod
3. Celková hrubá architektura
4. Hlavní obsah aplikace
5. Účel programu

---

## Historie Dokumentu
### Verze 1
* **Autor:** Jonáš Tenora
* **Komentář:** První verze dokumentu

---

## Úvod
* **Účel dokumentu** – Účelem dokumentu je popsání všech funkcí programu Wordle a nefunkčních požadavků.
* **Kontakt:** tenora.jo.2022@skola.ssps.cz

---

## Celková hrubá architektura
* **Jazyk aplikace:** Angličtina
* **Spuštění:** Po spuštění je hráč vyzván k zadání počtu pokusů (obtížnost). Poté začíná hra.
* **Platforma:** Aplikace běží v příkazovém řádku, tedy na konzoli. Je určena pro operační systémy podporující .NET.

---

## Hlavní obsah aplikace

### Uživatelské rozhraní
* Aplikace běží v prostředí příkazového řádku a komunikuje s uživatelem prostřednictvím textových výzev.
* Základní barvy používané pro zpětnou vazbu jsou:
  - **Cyan (modrá):** Pro obecné informace a instrukce.
  - **Red (červená):** Pro chybové zprávy a neplatné vstupy.
  - **Green (zelená):** Pro správná písmena na správném místě.
  - **Yellow (žlutá):** Pro správná písmena na špatném místě.
  - **White (bílá):** Pro písmena, která nejsou ve slově.

### Herní smyčka
1. **Výběr obtížnosti:** 
   - Při spuštění je hráč vyzván, aby zadal počet pokusů pro hru. Program akceptuje pouze kladná čísla.
   - V případě neplatného vstupu (např. text místo čísla) je zobrazena chybová zpráva a uživatel je vyzván k opětovnému zadání.
2. **Zadání slova:** 
   - Hráč zadává 5-písmenné slovo, které je validováno proti seznamu slov v souboru `words.txt`.
   - Pokud vstup není 5-písmenné slovo nebo není v seznamu, zobrazí se chybová zpráva a hráč je vyzván k opakování vstupu.
3. **Vyhodnocení slova:** 
   - Hra porovná vstup hráče s tajným slovem a zobrazí zpětnou vazbu barevným zobrazením správnosti písmen.
   - Písmena jsou zobrazena v řádcích podle pokusů a každé písmeno má barvu dle zpětné vazby.
4. **Konec hry:** 
   - Pokud hráč uhodne slovo, hra zobrazí gratulaci, správné slovo a nabídne možnost ukončení hry.
   - Pokud hráč neuhodne slovo v zadaném počtu pokusů, hra zobrazí správné slovo a nabídne možnost ukončení.

### Barevná zpětná vazba
- **Zelená:** Písmeno je na správné pozici.
- **Žlutá:** Písmeno je ve slově, ale na špatné pozici.
- **Bílá:** Písmeno není ve slově.

### Náhodné generování slova
- Slovo je na začátku hry náhodně vybráno ze souboru `words.txt`, který obsahuje seznam platných 5-písmenných slov.
- Hra používá třídu `Random` pro výběr náhodného slova ze seznamu.

### Způsob ukončení hry
- Hra se ukončí po správném uhodnutí slova nebo po vyčerpání všech pokusů.
- Po každém konci kola se hráč dotázán, zda chce ukončit hru (`y` pro ukončení, `n` pro pokračování).
- V případě, že hráč zadá jinou odpověď, než je `y` nebo `n`, se zobrazí chybová zpráva a dotaz je opakován.

---

## Účel programu

### Trénink logiky a slovní zásoby
Hra je navržena jako zábavný nástroj pro trénink logického myšlení a slovní zásoby hráče.

### Zlepšení strategie
Barevná zpětná vazba umožňuje hráči postupně vylepšovat strategii a logicky dedukovat správné slovo.

### Zpětná vazba na chyby
- **Neplatný vstup při výběru obtížnosti:** Pokud hráč nezadá číslo nebo zadá neplatný počet pokusů (např. `0`), hra zobrazí chybovou zprávu a požádá o opakování.
- **Neplatné slovo při hádání:** Pokud hráč zadá slovo, které není 5-písmenné nebo není v seznamu platných slov, zobrazí se chybová zpráva a hráč musí hádat znovu.
- **Neplatný vstup při ukončení hry:** Pokud hráč zadá jiný vstup než `y` nebo `n` při dotazu na ukončení hry, program opakuje dotaz.

---

Tato dokumentace obsahuje kompletní popis uživatelského rozhraní, způsobu interakce a řešení chybových stavů, aby poskytovala jasný přehled o fungování hry a očekávaném chování aplikace.
