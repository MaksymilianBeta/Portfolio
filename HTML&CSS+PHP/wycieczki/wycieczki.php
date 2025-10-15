<?php

$serwer = 'localhost';
$login  = 'root';
$haslo  = '';
$baza   = 'biuropodrozy';

$do_bazy= @mysqli_connect($serwer,$login,$haslo,$baza) or die ('nie dziala');?>
<html lang="PL-pl">

<head>
<meta charset="utf-8">
<link rel="stylesheet" href="styl4.css">
</head>



<body>
<section id="baner"> 
<h1>BIURO TURYSTYCZNE</h1>
</section>


<section id="dane">
<h3>Wycieczki na które sa wolne miejsca </h3>
<?php
$zapytanie ="SELECT wycieczki.id, 
wycieczki.dataWyjazdu, 
wycieczki.cel,
wycieczki.cena from wycieczki where wycieczki.dostepna=1;";

$wynik_zapytania = mysqli_query($do_bazy, $zapytanie);

if(mysqli_num_rows($wynik_zapytania) > 0){
print "<ul>";

while($wiersz = mysqli_fetch_assoc($wynik_zapytania)){
print "<li>" . $wiersz['id']." dnia ". $wiersz['dataWyjazdu']." jedziemy do ".$wiersz['cel']." cena:".$wiersz['cena']."</li>";
}
}

?>
 </section>

<section id="lewy">
<h2>Bestsellery</h2>
<table>
<tr><td>Wenecja </td><td>Kwiecien </td></tr>
<tr><td>Londyn</td><td>Lipiec</td></tr>
<tr><td>Rzym </td><td>Wrzesień </td></tr>
</table>
 </section>

<section id="srodkowy">
<h2>Nasze zdjęcia</h2>
<section id="galeria">
<?php
$zapytanie2 = 'SELECT zdjecia.Nazwapliku, zdjecia.podpis from zdjecia';

$wynik_zapytania2 = mysqli_query($do_bazy,$zapytanie2);

if (mysqli_num_rows($wynik_zapytania2) > 0){

while($wiersz = mysqli_fetch_assoc($wynik_zapytania2)){
$zdjecie = $wiersz['Nazwapliku'];
$podpis = $wiersz['podpis'];
print "<img src='$zdjecie' alt='$podpis'>";
} 
}
else {
print "brak wynikow";
}

?>

</section>
 </section>

<section id="prawy"> 
<h2>Skontaktuj się </h2>
<a href="mailto:maxbeta@o2.pl">napisz do nas </a>
<p>12132231312 </p>
</section>

<section id="stopka">
Strone wykonal maksiu 
 </section>







</body>



</html>







</html>