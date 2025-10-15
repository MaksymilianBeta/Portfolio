<!DOCTYPE HTML>
<html lang="pl-PL">
	<head>
		<meta charset="utf-8">
		<title>TURYSTYKA MOJA PASJA </title>
		<link rel="stylesheet" href="plik12.css">
	</head>
<body>

<section id="baner">
	<h1>Podróże z uśmiechem </h1>
 </section>
 <section id="ciasteczka"> 



 <?php 
	setcookie("ciastko","1");
	if (isset($_COOKIE["ciastko"])) {
	echo "Witaj ponownie na naszej stronie";
 }
 else {
	 echo "Witaj! Nasza Strona używa ciasteczek";
 }
	 

 
 
 
 
 
 
 
 ?>
 </section>
<section id="lewy">
<h2>Nasze wycieczki </h2>
<ol>
<li>autokarowe
<ul>
<li>po Polsce </li>
<li>do Niemiec i Czech </li>
 </ul>
</li>

<li>samolotem
<ul>
<li>Grecja</li>
<li>Barcelona</li>
<l1>Wenecja</li>
 </ul>
</li> 
</ol>
<h2>Pobierz dokumenty</h2>
<p><a href="regulamin.txt">Regulamin biura podróży</a></p>
<p><a href="http://galeria.pl/" target="blank">Zdjęcia naszych wycieczek </a></p>
 </section>




<section id="prawy">
<table>
	<tr> <td>
	<img src="polska.png" alt="Zwiedzanie Krakowa"> </td> <td>
	<img src="grecja.png" alt="Gorące greckie wyspy"> </td>     </tr>
	<tr> <td>
	<img src="wlochy.png" alt="Wenecja i nie tylko"> </td> <td>
	<img src="hiszpania1.png" alt="Słoneczna Barcelona"> </td>     </tr>
</table>
 </section>
<section id="stopka">
Stronę przygotował:69696969696969


 </section>



</body>


</html>