<!DOCTYPE html>
<html lang="PL-pl">

<head>
<meta charset="utf-8">
<title>Wynajem pokoi</title>
<link rel="stylesheet" href="styl9.css">
</head>

<body>
	<section id="baner">
		<h1>Pensjonat pod dobrym humorem</h1>
	</section>

	<section id="lewy">
		<a href="indexik.html">GŁÓWNA</a>
		<img src="pokoj11.jpg" alt="pokoje">
	</section>
		
	<section id="srodek">
		<a href="cennik.php">CENNIK</a>
		<table>
		<?php
		$do_bazy= mysqli_connect('localhost','root','','nowyegzamin');
		
		$zapytanie="SELECT * FROM pokoje;";
		
		$wynik_zapytania=mysqli_query($do_bazy,$zapytanie);
		
		if(mysqli_num_rows($wynik_zapytania)>0){
			while($wiersz=mysqli_fetch_assoc($wynik_zapytania)){
				print "<tr>";
				print "<td>".$wiersz["id"]."</td><td>".$wiersz["nazwa"]."</td><td>".$wiersz['cena']."</td>";
				print "</tr>";
				
			}
		}
		mysqli_close($do_bazy);
		?>
		</table>
	</section>

	<section id="prawy">
		<a href="kalkulator.html">KALKULATOR</a>
		<img src="pokoj13.jpg" alt="pokoje">
	</section>

	<section id="stopka">
		<p>strone wykonał maksymiliano</p>
	</section>

</body>

</html>