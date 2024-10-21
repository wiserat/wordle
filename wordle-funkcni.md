# Videohra v CLI: Wordle – Funkční požadavky
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
* **Účel dokumentu** – Účelem dokumentu je popsání všech funkcí programu Wordle a funkčních požadavků.
* **Kontakt:** tenora.jo.2022@skola.ssps.cz

---

## Celková hrubá architektura
* **Jazyk aplikace:** Angličtina
* **Spuštění:** Po spuštění je hráč vyzván k zadání počtu pokusů (obtížnost). Poté začíná hra.
* **Platforma:** Aplikace běží v příkazovém řádku, tedy na konzoli. Je určena pro operační systémy podporující .NET.

---

## Hlavní obsah aplikace

### Uživatelské rozhraní
* Aplikace běží v prostředí příkazového řádku a komunikuje s uživatelem prostřednictvím textových výzev. Program používá standardní výstupy pro zobrazení informací a vstupy pro interakci s hráčem.
* Použité barvy:
  - **Modrá:** Pro obecné informace a instrukce.
  - **Červená:** Pro chybové zprávy a neplatné vstupy.
  - **Zelená:** Pro správná písmena na správném místě.
  - **Žlutá:** Pro správná písmena na špatném místě.
  - **Bílá:** Pro písmena, která nejsou ve slově.

### Herní smyčka
1. **Výběr obtížnosti:**
   - Po spuštění hry je v terminálu hráč vyzván k zadání počtu pokusů, například výpisem textu: `Zadejte počet pokusů pro hru:`. Program čeká na zadání čísla pomocí metody `Console.ReadLine()`.
   - Pokud uživatel zadá neplatný vstup (např. text nebo záporné číslo), terminál vypíše chybovou zprávu: `Neplatný vstup. Zadejte prosím kladné číslo.` a program znovu čeká na zadání počtu pokusů.

2. **Zadání slova:**
   - V každém kole se v terminálu vypíše výzva k zadání 5-písmenného slova: `Zadejte 5-písmenné slovo:` a program čeká na vstup hráče pomocí `Console.ReadLine()`.
   - Pokud je vstup neplatný (např. slovo má jiný počet písmen nebo neexistuje v seznamu), terminál zobrazí chybovou zprávu: `Neplatné slovo, zkuste to znovu.` a hráč musí zadat nové slovo.

3. **Vyhodnocení slova:**
   - Po zadání slova program porovná jednotlivá písmena hráčova vstupu s tajným slovem. Barevná zpětná vazba je zobrazena na základě výsledku porovnání:
     - Správná písmena na správných pozicích jsou zobrazena zeleně: `Console.ForegroundColor = ConsoleColor.Green`.
     - Správná písmena na špatných pozicích jsou zobrazena žlutě: `Console.ForegroundColor = ConsoleColor.Yellow`.
     - Písmena, která nejsou ve slově, jsou zobrazena bílě: `Console.ForegroundColor = ConsoleColor.White`.
   - Každé písmeno je vypsáno na obrazovku s odpovídající barvou a výsledek je zobrazen jako řádek textu v terminálu.

4. **Konec hry:**
   - Pokud hráč správně uhodne slovo, program zobrazí gratulaci: `Gratulujeme! Uhodli jste slovo.` a následně dotaz, zda chce hráč ukončit hru: `Chcete ukončit hru? (y/n)`. Program pak čeká na vstup uživatele (`y` pro ukončení, `n` pro pokračování).
   - Pokud hráč neuhodne slovo v zadaném počtu pokusů, terminál zobrazí zprávu s tajným slovem: `Bohužel jste neuhodli. Tajné slovo bylo: [tajné slovo].` Následuje dotaz na ukončení hry.

### Barevná zpětná vazba
- **Zelená:** Písmeno je na správné pozici.
- **Žlutá:** Písmeno je ve slově, ale na špatné pozici.
- **Bílá:** Písmeno není ve slově.

### Náhodné generování slova
- Na začátku hry je ze seznamu slov náhodně vybráno slovo pomocí třídy `Random`. Program načte slova ze souboru `words.txt` a vybere jedno slovo, které hráč hádá.

### Způsob ukončení hry
- Po skončení každé hry (ať už vítězstvím, nebo prohrou) terminál vypíše dotaz: `Chcete ukončit hru? (y/n)` a čeká na vstup uživatele.
- V případě neplatného vstupu (např. něco jiného než `y` nebo `n`) se zobrazí chybová zpráva: `Neplatný vstup, prosím zadejte "y" nebo "n".` a dotaz se opakuje, dokud není zadán platný vstup.

---

## Účel programu

### Trénink logiky a slovní zásoby
Hra je navržena jako nástroj pro trénink logického myšlení a slovní zásoby hráče.

### Zlepšení strategie
Barevná zpětná vazba pomáhá hráči postupně vylepšovat strategii a logicky dedukovat správné slovo.

### Zpětná vazba na chyby
- **Neplatný vstup při výběru obtížnosti:** Pokud hráč zadá neplatný počet pokusů (např. text místo čísla nebo záporné číslo), program zobrazí chybovou zprávu a vyzve hráče k novému zadání.
- **Neplatné slovo při hádání:** Pokud hráč zadá slovo, které nesplňuje požadavky (není 5-písmenné nebo není ve slovníku), terminál zobrazí chybu a požádá o nové slovo.
- **Neplatný vstup při ukončení hry:** Pokud hráč zadá jiný vstup než `y` nebo `n`, dotaz na ukončení hry se opakuje, dokud není zadán platný vstup.
