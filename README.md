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
#
2. Aggiungere il file [chinook.db](https://github.com/Sateoo/GUIDb/blob/main/README.md#prerequisiti) alla cartella Raw
  * ![Raw](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/Raw.png)
 * Nelle proprietà mettere copia sempre
  * ![copia sempre](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/copia%20sempre.png)
#
3. Installare l'enstensione [sqlite-net-pcl](https://github.com/Sateoo/GUIDb/blob/main/README.md#prerequisiti)
#
4. Creare la classe Record.cs
 * Tasto destro sul nome del progetto tasto sinistro su aggiungi e tasto sinistro su classe
 ![aggiungi classe](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/aggiungi%20classe.png)
 * Chiamare la classe Record.cs e aggiungerla
 ![classe](https://github.com/Sateoo/GUIDb/blob/main/salvi.matteo.4h.GUIDb/salvi.matteo.4h.GUIDb/immagini/classe.png)
#
 5. Nella classe Recors.cs scrivere:
 ```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salvi.matteo._4h.GUIDb
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }

    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        public string Composer { get; set; }
        public Int64 Milliseconds { get; set; }
        public Int64 Bytes { get; set; }
        public double UnitPrice { get; set; }

    }
}
 ```
 Fare attenzione al namespace che và cambiato col nome del proprio progetto
#
6. In MainPage.xaml scrivere:
```
<Window x:Class="salvi.matteo._4h.GUIDb.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:salvi.matteo._4h.GUIDb.MainWindow"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <StackPanel Orientation="Vertical">
            <StackPanel>
                <Button Width="100" Click="Button_Click"></Button>
            </StackPanel>

            <DataGrid x:Name="dgDati"></DataGrid>
        </StackPanel>
    </Grid>
</Window>
```
Fare attenzione a x:Class e xmlns:local dove va cambiato il nome del progetto col proprio
#
7. In MainPage.xaml.cs scrivere:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLite;

namespace salvi.matteo._4H.GUIDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var cn1 = new SQLiteConnection("chinook.db");

            List<Artist> tblArtists;

            // Prende tutti gli artisti
            tblArtists = cn1.Query<Artist>("select * from artists where name like 'a%'");
            dgDati.ItemsSource = tblArtists;

        }
    }
}
```
Fare attenzione sempre al namespace dove va cambiato il nome del progetto col proprio
