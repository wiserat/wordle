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

---

## Hlavní obsah aplikace

### Herní smyčka
1. **Výběr obtížnosti:** Hra umožňuje hráči vybrat počet pokusů před začátkem hry.
2. **Zadání slova:** Hráč zadává 5-písmenné slovo, které je validováno proti slovníku.
3. **Vyhodnocení slova:** Hra porovná vstup hráče s tajným slovem a zobrazí zpětnou vazbu – písmena jsou vybarvena podle jejich správnosti.
4. **Konec hry:** Po uhodnutí slova, nebo vyčerpání všech pokusů, hra zobrazí výsledek a nabídne možnost ukončení.

### Barevná zpětná vazba
- **Zelená:** Písmeno je na správné pozici.
- **Žlutá:** Písmeno je ve slově, ale na špatné pozici.
- **Bílá:** Písmeno není ve slově.

### Náhodné generování slova
- Slovo je na začátku hry náhodně vybráno ze souboru `words.txt`, který obsahuje seznam platných 5-písmenných slov.

### Způsob ukončení hry
- Hra se ukončí po správném uhodnutí slova nebo po vyčerpání všech pokusů.

---

## Účel programu

### Trénink logiky a slovní zásoby
Hra je navržena jako zábavný nástroj pro trénink logického myšlení a slovní zásoby hráče.

### Zlepšení strategie
Barevná zpětná vazba umožňuje hráči postupně vylepšovat strategii a logicky dedukovat správné slovo.
