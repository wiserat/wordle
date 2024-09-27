# Videohra v CLI: Wordle - Business požadavky
* *SSPŠ*
* *Verze 1*
* *Václav Bohdanecký*
* *17.9.2024*

## Obsah
1. Historie Dokumentu
2. Úvod
3. Požadavky

## Historie Dokumentu
### Verze 1
* **Autor:** Václav Bohdanecký
* **Komentář:** První verze dokumentu

## Úvod
* **Účel dokumentu** – Účelem dokumentu je popsání všech požadovaných funkcí programu a nefunkčních požadavků.
* **Cílová skupina:** Pan učitel programování
* **Kontakt:** bohdanecky.va.2022@skola.ssps.cz
* **Odkazy na další dokumenty:** Wordle-Funkcni
* **Strany:** 
    1. **Provozovatel** - SSPŠ 
    2. **Uživatel** - Hráč

## Požadavky
### Funkční požadavky
* Hráč musí uhodnout tajné slovo o 5 písmenech během 6 pokusů.
* Po každém pokusu se hráči zobrazí zpětná vazba:
    * **Zelená** – písmeno je na správné pozici.
    * **Žlutá** – písmeno je ve slově, ale na jiné pozici.
    * **Šedá** – písmeno ve slově není.
* Program náhodně vybírá tajné slovo z předem definovaného seznamu slov.
* Hra končí buď po úspěšném uhodnutí slova, nebo po vyčerpání všech pokusů.
* Na konci hry se hráči zobrazí buď vítězství nebo porážka a tajné slovo.
* Po ukončení hry se program zeptá, zda chce hráč začít novou hru.
* Skóre se může ukládat do souboru spolu s datem a počtem pokusů, pokud hráč vyhraje.

### Nefunkční požadavky
* **CLI Aplikace** - aplikace bude vyvinuta pro prostředí příkazové řádky.
* **Podporované zařízení** - aplikace bude optimalizována pouze pro zařízení, která podporují .NET v příkazovém prostředí verze 4.8 a novější.
* **Zobrazení** - aplikace bude zobrazena jako textové okno v CLI.
* **Vývojové prostředí** - aplikace bude vyvíjena ve Visual Studio 2022 v .NET frameworku.
