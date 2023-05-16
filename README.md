# GUIDb
using serve per staccarsi dal database e chiama il metodo distruttore
per chiamare un metodo Async serve un await 
file.writeallbytes serve per scrivere
## Prerequisiti
* Installare il database chinook.db -> SQLite sample database ([download](https://www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip))
* Installare l'estensione SQLite su Visual Studio
  * per installarla, cliccare con il tasto destro su dipendenze e poi con il sinistro su gestisci pacchetti NuGet
  ![per libreria](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/per%20libreria.png)
  * si aprirà la finestra per l'installazione delle librerie, scrivere nella barra di ricerca
  ```
  sqlite-net-pcl
  ```
  * e scaricare il primo risultato
  ![libreria](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/libreria.png)
#
## Creazione passo passo
1. Aprire Visual Studio e creare un nuovo progetto MAUI (App .NET MAUI
 ![creazione MAUI](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/creazione%20MAUI.png)
2. aggiungere il file [chinook.db](https://github.com/Sateoo/GUIDb/blob/main/README.md#prerequisiti) alla cartella Raw
![Raw](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/Raw.png)
 * nelle proprietà mettere copia sempre
![copia sempre](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/copia%20sempre.png)
3. Installare l'enstensione [sqlite-net-pcl](https://github.com/Sateoo/GUIDb/blob/main/README.md#prerequisiti)
4. Creare la classe Record.cs
 * tasto destro sul nome del progetto tasto sinistro su aggiungi e tasto sinistro su classe
 ![aggiungi classe](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/aggiungi%20classe.png)
 * chiamare la classe Record.cs e aggiungerla
 ![classe](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/classe.png)
