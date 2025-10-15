<?php
$do_bazy= @mysqli_connect('localhost','root','','kalendarz') or die ('nie dziala');

?>

<html lang="PL-pl">

<head>
<meta charset="utf-8">
<link rel="stylesheet" href="styl34.css">
<title>Sierpniowy kalendarz </title>


</style>
</head>



<body>
<section id="baner"> 
<h1>Organizer: SIERPIEŃ </h1>
</section>


<section id="baner2">
<form action="organizer.php" method="POST">
Zapisz wydarzenie:<input type="text" name="tekst"> <input type="submit" name="pobierz"value="OK">
<?php
if (!isset($_POST['tekst'])){
	echo "wpisz wpis";
} else{
	$tekst=$_POST['tekst'];
	$aktualizacja = "UPDATE zadania SET wpis = '$tekst' where zadania.dataZadania='2020-08-02'";
	$zapytanie1 = mysqli_query($do_bazy, $aktualizacja);
}?>
</form>
 </section>

<section id="baner3">
<IMG sRC="logo3.jpg" alt="sierpień">
</section>

<section id="glowny">
<?php
$zapytanie2 = "SELECT zadania.dataZadania, zadania.wpis from zadania where miesiac='sierpien'";

$wynik_zapytania2 = mysqli_query($do_bazy, $zapytanie2);

if (mysqli_num_rows($wynik_zapytania2) > 0){

while($wiersz = mysqli_fetch_assoc($wynik_zapytania2)){
$wpis = $wiersz['wpis'];
$data= $wiersz['dataZadania'];

 print "<div id='dzien'>";
 print "<h5>". $data ."</h5>";
 print "<p>". $wpis . "</p>"; 
 print "</div>";
}
} else {
print "brak wynikow";
}
?>
</section>



<section id="stopka">
Strone wykonal maksiu 
 </section>
</body>



</html>