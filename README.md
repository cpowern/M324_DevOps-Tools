# To-Do App in C#

## Beschreibung
Diese einfache To-Do-App wurde in C# entwickelt und ermöglicht es dem Benutzer, Aufgaben hinzuzufügen und anzuzeigen. Sie läuft in der Konsole und bietet eine minimalistische, aber funktionale Möglichkeit zur Verwaltung von Aufgaben.

## Funktionen
- **Aufgabe hinzufügen**: Der Benutzer kann neue Aufgaben eingeben, die in einer Liste gespeichert werden.
- **Aufgaben anzeigen**: Eine Übersicht der gespeicherten Aufgaben wird ausgegeben.
- **Programm beenden**: Das Programm kann jederzeit über das Menü beendet werden.

## Verwendete Technologien
- **Programmiersprache**: C#
- **Laufzeitumgebung**: .NET
- **Eingabe/Ausgabe**: Konsolenbasiert

## Struktur des Codes
Das Projekt besteht aus zwei Hauptklassen:

### **Program.cs**
Die `Program`-Klasse enthält die Hauptmethode `Main()`, die eine Instanz von `TodoManager` erstellt und eine Schleife bereitstellt, um Benutzereingaben zu verarbeiten. Über ein einfaches Menü können verschiedene Optionen gewählt werden.

### **TodoManager.cs**
Die `TodoManager`-Klasse verwaltet die Aufgaben. Sie verwendet eine `List<string>` zur Speicherung und stellt Methoden bereit, um Aufgaben hinzuzufügen (`AddTask()`) und anzuzeigen (`ShowTasks()`).

## Nutzung
1. **Starten**: Das Programm in einer C#-fähigen Umgebung kompilieren und ausführen.
2. **Option wählen**: Im Konsolenmenü eine Zahl eingeben:
   - `1` zum Hinzufügen einer Aufgabe
   - `2` zum Anzeigen der Aufgabenliste
   - `3` zum Beenden des Programms
3. **Interagieren**: Aufgaben verwalten, bis das Programm beendet wird.

## Mögliche Erweiterungen
- **Löschen von Aufgaben**: Eine Funktion zum Entfernen erledigter Aufgaben
- **Speicherung**: Persistente Speicherung der Aufgaben in einer Datei oder Datenbank
- **Grafische Benutzeroberfläche**: Umsetzung als Desktop- oder Web-App für eine verbesserte Nutzererfahrung

## Fazit
Diese einfache To-Do-App bietet eine gute Basis für den Einstieg in die C#-Programmierung und kann leicht erweitert werden. Sie ist ideal für kleine persönliche Projekte oder zum Üben der Grundlagen von Objektorientierung und Konsoleninteraktion in C#.

