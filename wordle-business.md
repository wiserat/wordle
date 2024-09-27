# CLI Wordle Business
* *SSPŠ*
* *Verze 1*
* *Jonáš Tenora*
* *27.9.2024*

## Obsah
1. Historie Dokumentu
2. Úvod
3. Požadavky

## Historie Dokumentu
### Verze 1
* **Autor:** Jonáš Tenora
* **Komentář:** Initial

## Úvod
* **Účel dokumentu** – Účelem dokumentu je popsání všech požadovaných funkcí programu a nefunkčních požadavků.
* **Cílová skupina:** Hráči Wordle bez GUI
* **Kontakt:** tenora.jo.2022@skola.ssps.cz
* **Odkazy na další dokumenty:** wordle-funkcni.md
* **Strany:** 
    1. **Provozovatel** - Jonáš Tenora
    2. **Uživatel** - Hráč

## Požadavky
### Funkční požadavky
* Hráč musí uhodnout tajné slovo o 5 písmenech během 6 pokusů.
* Po každém pokusu se hráči zobrazí zpětná vazba:
    * **Zelená** – písmeno je na správné pozici.
    * **Žlutá** – písmeno je ve slově, ale na jiné pozici.
    * **Beze změny** – písmeno ve slově není.
* Program vybírá tajné slovo.
* Hra končí buď po úspěšném uhodnutí slova, nebo po vyčerpání všech pokusů.
* Na konci hry se hráči zobrazí buď vítězství nebo porážka a tajné slovo.

### Nefunkční požadavky
* **CLI Aplikace** - aplikace bude vyvinuta pro prostředí příkazové řádky.
* **Podporované zařízení** - aplikace bude optimalizována pouze pro zařízení, která podporují .NET v příkazovém prostředí verze 4.8 a novější.
* **Zobrazení** - aplikace bude zobrazena jako textové okno v CLI.
* **Vývojové prostředí** - aplikace bude vyvíjena v JetBrains Rider.
