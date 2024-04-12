# Kasutajatoe pöördumiste haldamise rakendus

## Tutvustus ja kasutamine
Rakenduse põhifunktsioonid:
- Kasutaja saab sisestada pöördumise. 
-  Pöördumisel on kirjeldus, sisestamise aeg, lahendamise tähtaeg. 
- Sisestamise ajaks märgitakse pöördumise sisestamise aeg, teised 
kohustuslikud väljad täidab kasutaja. 
- Kasutajale kuvatakse aktiivsed pöördumised koos kõigi väljadega nimekirjas 
sorteeritult kahanevalt lahendamise tähtaja järgi. 
- Pöördumised, mille lahendamise tähtajani on jäänud vähem kui 1 tund või mis 
on juba ületanud lahendamise tähtaja, kuvatakse nimekirjas punasena. 
- Kasutaja saab nimekirjas pöördumisi lahendatuks märkida, mis kaotab 
pöördumise nimekirjast.

## Paigaldamine
1. **Kloonige see repo oma arvutisse:** Kasutage selleks käsku `git clone https://github.com/liidiailves/todo-app.git`.
2. **Navigeerige projekti kausta:** Avage terminal ja liikuge rakenduse projekti kausta.
3. **Käivitage rakendus:** Kasutage käsku `dotnet run`, et käivitada rakendus. Seejärel avage veebibrauser ja minge aadressile `https://localhost:5001`.

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