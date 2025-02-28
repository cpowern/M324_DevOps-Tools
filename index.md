<!DOCTYPE html>
<html lang="de">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>To-Do App in C#</title>
  <style>
    /* Basis-Reset */
    * {
      box-sizing: border-box;
      margin: 0;
      padding: 0;
    }

    body {
      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
      background: #f0f4f8;
      color: #333;
      line-height: 1.6;
    }

    /* Header */
    header {
      background: linear-gradient(90deg, #4b79a1, #283e51);
      color: #fff;
      padding: 20px 0;
      text-align: center;
    }
    
    header h1 {
      margin-bottom: 10px;
      font-size: 2.5rem;
    }
    
    nav a {
      color: #fff;
      margin: 0 10px;
      text-decoration: none;
      font-weight: bold;
      transition: color 0.3s ease;
    }
    
    nav a:hover {
      color: #ffdd57;
    }
    
    /* Hauptcontainer */
    .container {
      max-width: 1000px;
      margin: 40px auto;
      padding: 20px;
      background: #fff;
      box-shadow: 0 0 20px rgba(0,0,0,0.1);
      border-radius: 8px;
    }
    
    section {
      margin-bottom: 40px;
    }
    
    h2 {
      color: #4b79a1;
      margin-bottom: 10px;
      border-bottom: 2px solid #4b79a1;
      display: inline-block;
      padding-bottom: 5px;
    }
    
    h3 {
      margin-top: 20px;
      color: #283e51;
    }
    
    p {
      margin-bottom: 15px;
    }
    
    ul, ol {
      margin-left: 20px;
      margin-bottom: 15px;
    }
    
    ul li, ol li {
      background: #e7eff6;
      margin-bottom: 8px;
      padding: 10px;
      border-radius: 4px;
    }
    
    code {
      background: #eee;
      padding: 2px 4px;
      border-radius: 4px;
    }
    
    /* Footer */
    footer {
      text-align: center;
      padding: 20px 0;
      background: #283e51;
      color: #fff;
    }
  </style>
</head>
<body>

  <header>
    <h1>To-Do App in C#</h1>
    <nav>
      <a href="#beschreibung">Beschreibung</a>
      <a href="#funktionen">Funktionen</a>
      <a href="#technologien">Technologien</a>
      <a href="#struktur">Struktur</a>
      <a href="#nutzung">Nutzung</a>
      <a href="#erweiterungen">Erweiterungen</a>
    </nav>
  </header>

  <div class="container">
    <section id="beschreibung">
      <h2>Beschreibung</h2>
      <p>Diese einfache To-Do-App wurde in C# entwickelt und ermöglicht es dem Benutzer, Aufgaben hinzuzufügen und anzuzeigen. Sie läuft in der Konsole und bietet eine minimalistische, aber funktionale Möglichkeit zur Verwaltung von Aufgaben.</p>
    </section>

    <section id="funktionen">
      <h2>Funktionen</h2>
      <ul>
        <li><strong>Aufgabe hinzufügen:</strong> Der Benutzer kann neue Aufgaben eingeben, die in einer Liste gespeichert werden.</li>
        <li><strong>Aufgaben anzeigen:</strong> Eine Übersicht der gespeicherten Aufgaben wird ausgegeben.</li>
        <li><strong>Programm beenden:</strong> Das Programm kann jederzeit über das Menü beendet werden.</li>
      </ul>
    </section>

    <section id="technologien">
      <h2>Verwendete Technologien</h2>
      <ul>
        <li><strong>Programmiersprache:</strong> C#</li>
        <li><strong>Laufzeitumgebung:</strong> .NET</li>
        <li><strong>Eingabe/Ausgabe:</strong> Konsolenbasiert</li>
      </ul>
    </section>

    <section id="struktur">
      <h2>Struktur des Codes</h2>
      <p>Das Projekt besteht aus zwei Hauptklassen:</p>
      <h3>Program.cs</h3>
      <p>Die <code>Program</code>-Klasse enthält die Hauptmethode <code>Main()</code>, die eine Instanz von <code>TodoManager</code> erstellt und eine Schleife bereitstellt, um Benutzereingaben zu verarbeiten. Über ein einfaches Menü können verschiedene Optionen gewählt werden.</p>
      <h3>TodoManager.cs</h3>
      <p>Die <code>TodoManager</code>-Klasse verwaltet die Aufgaben. Sie verwendet eine <code>List&lt;string&gt;</code> zur Speicherung und stellt Methoden bereit, um Aufgaben hinzuzufügen (<code>AddTask()</code>) und anzuzeigen (<code>ShowTasks()</code>).</p>
    </section>

    <section id="nutzung">
      <h2>Nutzung</h2>
      <ol>
        <li><strong>Starten:</strong> Das Programm in einer C#-fähigen Umgebung kompilieren und ausführen.</li>
        <li><strong>Option wählen:</strong> Im Konsolenmenü eine Zahl eingeben:
          <ul>
            <li><code>1</code> zum Hinzufügen einer Aufgabe</li>
            <li><code>2</code> zum Anzeigen der Aufgabenliste</li>
            <li><code>3</code> zum Beenden des Programms</li>
          </ul>
        </li>
        <li><strong>Interagieren:</strong> Aufgaben verwalten, bis das Programm beendet wird.</li>
      </ol>
    </section>

    <section id="erweiterungen">
      <h2>Mögliche Erweiterungen</h2>
      <ul>
        <li><strong>Löschen von Aufgaben:</strong> Eine Funktion zum Entfernen erledigter Aufgaben.</li>
        <li><strong>Speicherung:</strong> Persistente Speicherung der Aufgaben in einer Datei oder Datenbank.</li>
        <li><strong>Grafische Benutzeroberfläche:</strong> Umsetzung als Desktop- oder Web-App für eine verbesserte Nutzererfahrung.</li>
      </ul>
    </section>

    <section id="fazit">
      <h2>Fazit</h2>
      <p>Diese einfache To-Do-App bietet eine gute Basis für den Einstieg in die C#-Programmierung und kann leicht erweitert werden. Sie ist ideal für kleine persönliche Projekte oder zum Üben der Grundlagen von Objektorientierung und Konsoleninteraktion in C#.</p>
    </section>
  </div>

  <footer>
    <p>&copy; 2025 To-Do App in C#</p>
  </footer>

</body>
</html>
