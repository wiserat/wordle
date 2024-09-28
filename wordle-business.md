Videohra v CLI: Wordle – Business požadavky

	•	SSPŠ
	•	Verze 1
	•	Václav Bohdanecký
	•	17.9.2024

Obsah

	1.	Historie Dokumentu
	2.	Úvod
	3.	Požadavky

Historie Dokumentu

Verze 1

	•	Autor: Václav Bohdanecký
	•	Komentář: První verze dokumentu

Úvod

	•	Účel dokumentu – Účelem dokumentu je popsání všech požadovaných funkcí hry Wordle a nefunkčních požadavků.
	•	Cílová skupina: Pan učitel programování
	•	Kontakt: bohdanecky.va.2022@skola.ssps.cz
	•	Odkazy na další dokumenty: Wordle-CSharp-Funkcni
	•	Strany:
	1.	Provozovatel - SSPŠ
	2.	Uživatel - Hráč

Požadavky

Funkční požadavky

	•	Hráč musí uhodnout 5-písmenné slovo ve stanoveném počtu pokusů
Priorita: Vysoká
	•	Hra umožňuje hráči zvolit obtížnost – počet pokusů
Priorita: Vysoká
	•	Po každém pokusu hra poskytuje zpětnou vazbu barevným zobrazením správnosti písmen (zelená – správné písmeno na správném místě, žlutá – správné písmeno na špatném místě, bílá – špatné písmeno)
Priorita: Vysoká
	•	Po správném uhodnutí slova hra nabídne možnost ukončení
Priorita: Střední
	•	Pokud hráč neuhodne slovo v zadaném počtu pokusů, hra zobrazí správné slovo a nabídne možnost ukončení
Priorita: Střední
	•	Hra poskytuje jednoduché textové rozhraní s barevným výstupem pro zpětnou vazbu
Priorita: Střední

Nefunkční požadavky

	•	CLI Aplikace - Hra poběží v prostředí příkazového řádku.
	•	Podporovaná zařízení - Hra bude optimalizována pro .NET prostředí.
	•	Vývojové prostředí - Aplikace bude vyvíjena v Visual Studio 2022 s využitím .NET Frameworku.
