<?php
$do_bazy=mysqli_connect('localhost','root','','biblioteka');
?>
<!DOCTYPE HTML>
<html lang="pl-PL">

<head>
<meta charset="utf-8">
<title>Biblioteka</title>
<link rel="stylesheet" href="style1.css">
</head>

<body>

<section id="baner">
		<h1>Biblioteka w Ksiązkowicach Małych</h1>
 </section>
 
<section id="lewy">
<form action="biblioteka.php" method="POST">
	Imię:<input type="text" name="imie"><br>
	Nazwisko:<input type="text" name="nazwisko"><br>
	Symbol:<input type="number" name="kod"><br>
	<input type="submit" value="AKCEPTUJ" name="przycisk">
	<?php
	if(empty($_POST['imie']) && empty($_POST['nazwisko']) && empty($_POST['symbol'])){
	echo "podaj wartości";
	} else {
	$imie=$_POST['imie'];
	$nazwisko=$_POST['nazwisko'];
	$symbol=$_POST['kod'];
	echo "Dodano czytelnika $imie $nazwisko";
	$zapytanie="INSERT INTO `czytelnicy`(`id`, `imie`, `nazwisko`, `kod`) VALUES
	('NULL','$imie','$nazwisko','$symbol');";
    $wynik_zapytania=mysqli_query($do_bazy,$zapytanie);
	}
	
	?>
	</form>
 </section>
 
<section id="srodek">
		<img src="biblioteka.png" alt="biblioteka">
		<h6>ul.Czytelników&nbsp 15 Książkowice Małe</h6>
		<a href="mailto:biuro@bib.pl"><p>Czy masz jakieś uwagi?</p></a>
 </section>
<section id="prawy">
	<h4>Nasi czytelnicy</h4>
	<?php
	
	$zapytanie2="SELECT `imie`, `nazwisko` FROM `czytelnicy` order by `nazwisko` ASC;";
	print "<ol>";
	$wynik_zapytania2=mysqli_query($do_bazy,$zapytanie2);
	
	if(mysqli_num_rows($wynik_zapytania2)>0){
	print mysqli_num_rows($wynik_zapytania2);
	while($wiersz=mysqli_fetch_assoc($wynik_zapytania2)){
	print "<li>";
	print $wiersz['imie'];
	print " ";
	print $wiersz['nazwisko'];
	print "</li>";}
	}
	print "</ol>";
	?>
 </section>
<section id="stopka">
		<p>Projekt witryny:0420420402</p>
 </section>


</body>

</html>
<?php
mysqli_close($do_bazy);
?>