# Kasutajatoe p��rdumiste haldamise rakendus

## Tutvustus ja kasutamine
Rakenduse p�hifunktsioonid:
- Kasutaja saab sisestada p��rdumise. 
-  P��rdumisel on kirjeldus, sisestamise aeg, lahendamise t�htaeg. 
- Sisestamise ajaks m�rgitakse p��rdumise sisestamise aeg, teised 
kohustuslikud v�ljad t�idab kasutaja. 
- Kasutajale kuvatakse aktiivsed p��rdumised koos k�igi v�ljadega nimekirjas 
sorteeritult kahanevalt lahendamise t�htaja j�rgi. 
- P��rdumised, mille lahendamise t�htajani on j��nud v�hem kui 1 tund v�i mis 
on juba �letanud lahendamise t�htaja, kuvatakse nimekirjas punasena. 
- Kasutaja saab nimekirjas p��rdumisi lahendatuks m�rkida, mis kaotab 
p��rdumise nimekirjast.

## Paigaldamine
1. **Kloonige see repo oma arvutisse:** Kasutage selleks k�sku `git clone https://github.com/liidiailves/todo-app.git`.
2. **Navigeerige projekti kausta:** Avage terminal ja liikuge rakenduse projekti kausta.
3. **K�ivitage rakendus:** Kasutage k�sku `dotnet run`, et k�ivitada rakendus. Seej�rel avage veebibrauser ja minge aadressile `https://localhost:5001`.

## Konfiguratsioon
Rakenduse konfiguratsioon on seadistatud `appsettings.json` failis. 

---

# User Support Ticket Management Application

## Introduction and Usage
Key features of the application:
- Users can submit support tickets.
- Each ticket includes a description, submission time, and deadline for resolution.
- The submission time is automatically recorded, and users fill in other mandatory fields.
- Users can view active tickets sorted in descending order by the deadline for resolution.
- Tickets with less than 1 hour remaining until the deadline or those that have already passed the deadline are displayed in red.
- Users can mark tickets as resolved, removing them from the list.

## Installation
1. **Clone this repository to your computer: Use the command `git clone https://github.com/liidiailves/todo-app.git`.
2. **Navigate to the project directory: Open a terminal and move to the project directory of the application.
3. **Run the application: Use the command `dotnet run` to run the application. Then, open a web browser and go to `https://localhost:5001`.

## Configuration
The application's configuration is set in the `appsettings.json` file.