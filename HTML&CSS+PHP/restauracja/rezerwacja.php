<!DOCTYPE html>
<html lang="PL-pl">
<head>
<title>Restauracja Wszyskie Smaki</title>
<meta charset="utf-8">
<link rel="stylesheet" href="styl_2.css">

</head>
<body>
	<section id="baner">
		<h1>Witamy w restauracji "Wszystkie Smaki"</h1> </section>
	<section id="lewy">
		<img src="menu.jpg" alt="Nasze danie">
	</section>
	<section id="prawy">
		<h4>U nas dobrze zjesz!</h4>
		<ol>
			<li>Obiady po 40 zł</li>
			<li>Przekąski po 10 zł</li>
			<li>Kolacje po 20 zł</li>
		</ol>
	</section>
	<section id="dolny">
			<h2>Zarezerwuj stolik on-line</h2>
		<form action="rezerwacja.php" method="POST">
			Data (format rrrr-mm-dd):<br>
			<input type="date" name="data"><br>
			Ile osób?<br>
			<input type="number" name="ile_osob"><br>
			Twój numer telefonu:<br>
			<input type="number" name="telefon"><br>
			Numer stolika:<br>
			<input type="number" name="nr_stolika"><br>
			<input type="checkbox" name="dane">Zgadzam się na przetwarzanie moich danych osobowych<br>
			<input type="reset" value="Wyczyść" name="res">
			<input type="submit" name="wys" value="Rezerwuj">
			<?php
			
			if(!isset($_POST['dane'])){
			echo "nie wyraziłeś zgody";
			} else {
			$do_bazy = mysqli_connect('localhost','root','','baza');
			$data=$_POST['data'];
			$nr=$_POST['nr_stolika'];
			$liczba=$_POST['ile_osob'];
			$tel=$_POST['telefon'];
			$dodaj ="INSERT INTO rezerwacje 
			(id, numer_stolika, data_rez, liczba_osob, telefon)
			VALUES ('NULL','$nr','$data','$liczba','$tel')";
			$zapytanie = mysqli_query($do_bazy,$dodaj);
if(!$zapytanie===true) {
	echo "<br>";
	echo "NIE DODANO DO BAZY";
} else{
	echo "DODANO DO BAZY";
			}
			
			mysqli_close($do_bazy);
			}
			?>
		</form>
	</section>
	<section id="stopka">
		<i>Strone opracował:042040204204200</i>
	</section>


</body>











</html>