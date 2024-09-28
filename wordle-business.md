Business dokumentace

Videohra v CLI: Wordle

	•	Verze 1
	•	Autor: Václav Bohdanecký
	•	Datum: 17.9.2024

Obsah

	1.	Historie dokumentu
	2.	Úvod
	3.	Požadavky

Historie dokumentu

Verze 1

	•	Autor: Václav Bohdanecký
	•	Komentář: První verze dokumentu

Úvod

	•	Účel dokumentu: Tento dokument popisuje herní koncept a funkcionality konzolové verze hry inspirované Wordlem. Uvádí jak požadavky na hratelnost, tak technické vlastnosti.
	•	Cílová skupina: Pan učitel programování
	•	Kontakt: bohdanecky.va.2022@skola.ssps.cz
	•	Odkazy na další dokumenty: Wordle-CSharp-Funkcni
	•	Strany:
	1.	Provozovatel - SSPŠ
	2.	Uživatel - Hráč

Požadavky

Funkční požadavky

	1.	Hráč musí uhodnout 5-písmenné slovo ve stanoveném počtu pokusů.
Priorita: Vysoká
	2.	Hra umožňuje hráči zvolit obtížnost - počet pokusů.
Priorita: Vysoká
	3.	Po každém pokusu hra vyhodnotí správnost písmen a zvýrazní je barvami: zelená pro správná písmena na správném místě, žlutá pro písmena ve slově na špatném místě, a bílá pro písmena, která ve slově nejsou.
Priorita: Vysoká
	4.	Po správném uhodnutí slova hra nabídne možnost ukončení.
Priorita: Střední
	5.	Pokud hráč neuhodne slovo v zadaném počtu pokusů, zobrazí se správné slovo a hra nabídne možnost ukončení.
Priorita: Střední
	6.	Hra musí poskytovat jednoduché textové uživatelské rozhraní s barevným výstupem pro zpětnou vazbu na vstup hráče.
Priorita: Střední

Nefunkční požadavky

	1.	CLI Aplikace: Hra bude spuštěna a běžet v příkazovém řádku.
	2.	Podporovaná zařízení: Hra bude optimalizována pro prostředí .NET a příkazový řádek.
	3.	Vývojové prostředí: Vývoj probíhá ve Visual Studio 2022 s využitím .NET Frameworku.
