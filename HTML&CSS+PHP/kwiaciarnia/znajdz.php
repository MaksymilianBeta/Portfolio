<?php
$do_bazy=mysqli_connect('localhost','root','','kwiaciarnia');

if(isset($_POST['miasto'])){
$miasto=$_POST['miasto'];
$zapytanie= "SELECT nazwa, ulica FROM `kwiaciarnie` WHERE kwiaciarnie.miasto='$miasto';";

$wynik_zapytania=mysqli_query($do_bazy,$zapytanie);
} else {
	echo "Podaj miasto!!!";
}

$z_bazy=mysqli_close($do_bazy)
?>
<!DOCTYPE html>
<html lang="pl">
<head>
	<meta charset="utf-8">
	<title>Kwiaty</title>
	<link rel="stylesheet" href="styl3.css">
</head>
<body>
	<div id="baner">
		<h1>Grupa Polskich Kwiaciarni</h1>
	</div>
	<div id="lewy">
		<h2>Menu</h2>
		<ol>
			<li>
			<a href="index.html">Strona główna</a>
			</li>
			<li>
			<a href="https://www.kwiaty.pl/" target="_blank">Ropoznaj kwiaty</a>
			</li>
			<li>
				<a href="znajdz.php">Znajdź kwiaciarnię</a>
				<ul>
					<li><span>W Warszawie</span></li>
					<li><span>W Malborku</span></li>
					<li><span>W poznaniu</span></li>
				</ul>
			</li>
		</ol>
	</div>
	<div id="prawy">
		<h2>Znajdź kwiaciarnię</h2>
		<form action="znajdz.php" method="POST">
			Podaj nazwę miasta:<input type="text" name="miasto"/>
			<button type="submit">SPRAWDŹ</button>
			<?php
			if(isset($_POST['miasto'])){
				if(mysqli_num_rows($wynik_zapytania)>0){
			while($wiersz=mysqli_fetch_assoc($wynik_zapytania)){
			echo "<h3>".$wiersz['nazwa'].", ".$wiersz['ulica']."</h3>";
				}
			}
			}
			?>
		</form>
	</div>
	<div id="stopka">
		<p>Stronę opracował: maksiu
		</p>
	</div>
</body>
</html>