<?php 

$serwer = 'localhost';
$login  = 'root';
$haslo  = '';
$baza   = 'baza';

$do_bazy = mysqli_connect('localhost','root',"","baza") or die("nie udało się połączyć z baza");

$zapytanie = "SELECT ryby.nazwa, lowisko.akwen, lowisko.wojewodztwo from ryby inner join lowisko on ryby.id=lowisko.Ryby_id where lowisko.rodzaj=2;";

$wynik_zapytania = mysqli_query($do_bazy, $zapytanie);

$zapytanie2= "SELECT ryby.id, ryby.nazwa, ryby.wystepowanie from ryby 
where ryby.styl_zycia=2;";
//print_r($zapytanie);

$wynik_zapytania2 = mysqli_query($do_bazy, $zapytanie2);
?>




<!DOCTYPE HTML>
<html lang="PL-pl">

<head>
<meta charset="utf-8">
<title>Wędkowanie</title>
<link rel="stylesheet" href="styl4201.css">
</head>

<body>


<div id="baner">
<h1>Portal dla wędkarzy</h1>
</div>



 <main>
<div id="lewyall">
<div id="lewy">
<h3>Ryby zamieszkujace rzeki</h3>

<?php

if (mysqli_num_rows($wynik_zapytania) > 0){
	
	print "<ol>";
	
	while($wiersz = mysqli_fetch_assoc($wynik_zapytania)) {
		print "<li>". ' ' .$wiersz["nazwa"]. ' ' .$wiersz["akwen"]. ' ' .$wiersz["wojewodztwo"]. "</li>";
	}
	print "<ol>";
	
} else {
	print "Brak wyników";
}

?> 


</div>

<div id="lewy2">
<h3>Ryby drapieżne naszych wód</h3>


<?php
if (mysqli_num_rows($wynik_zapytania2) > 0){
	print "<table>";
	print "<tr> <th>L.p </th> <th>Gatunek</th> <th>Występowanie</th> </tr>";
	
	while($wiersz=mysqli_fetch_assoc($wynik_zapytania2)){
		print "<tr><td>".$wiersz["id"]."</td><td>".$wiersz["nazwa"]."</td><td>".$wiersz["wystepowanie"]."</td></tr>";
	}
	print "</table>";
}
else {
	print "brak wyników";
}

mysqli_close($do_bazy);
?>
</table>

</div>

</div>
</main>

<div id="prawy">
<img src="ryba123.jpg" alt="sum"><br>
<a href="kwerendycz22prak2.txt">Pobierz Kwerendy </a>
</div>


<div id="stopka">
<p>Stronę wykonał: 04240042042 </p>
</div>


</body>

</html>