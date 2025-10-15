<?Php
$do_bazy = @mysqli_connect('localhost','root','','sklep')
?>
<!DOCTYPE HTML>
<html lang="PL">
<head>
	<meta charset="utf=8">
	<title>Hurtownia szkolna </title>
	<link rel="stylesheet" href="stajl3.css">
</head>
<body action="hurtownia.php" method="POST">

	<section id="baner">
		<h1>Hurtownia z najlepszymi cenami</h1>
	</section>
	
	<section id="lewy">
		<h2>Nasze Ceny<h2>
		<table>
		<?php
		$zapytanie = "SELECT towary.nazwa, towary.cena from towary limit 4;";
		$wynik_zapytania = mysqli_query($do_bazy,$zapytanie);
		if (mysqli_num_rows($wynik_zapytania)> 0){
		while($wiersz=mysqli_fetch_assoc($wynik_zapytania)){
		
		print "<tr><td>" . $wiersz['nazwa'] . "</td>"."<td>" . $wiersz['cena'] . "</td></tr>";
		
		}
		}
		?>
		</table>
	</section>
	
	<section id="srodek">
		<h2>Koszt zakupów</h2>
		<form action="hurtownia.php" method="POST">
			Wybierz artykuł:<select name="lista">
				<option value="Zeszyt 60 kartek">Zeszyt 60 kartek</option>
				<option value="Zeszyt 32 kartki">Zeszyt 32 kartki</option>
				<option value="Cyrkiel">Cyrkiel</option>
				<option value="Linijka 30 cm">Linijka 30 cm</option>
				</select><br>
			Liczba sztuk:<input type="number" min="1" name="sztuki"><br>
			<input type="submit" value="OBLICZ">
			<?php
			if(empty($_POST['sztuki'])){
			print "Wprowadź ilość";
			}
			
			if ((isset($_POST['lista'])) && (isset($_POST['sztuki'])) && (!empty($_POST['sztuki'])) ){
			$wybor=$_POST['lista'];
			$liczba=$_POST['sztuki'];
			$zapytanie2 = "SELECT towary.cena from towary where towary.nazwa = '$wybor';";
			$wynik_zapytania2=mysqli_query($do_bazy, $zapytanie2);
			
			if (mysqli_num_rows($wynik_zapytania2)>0){
			while($wiersz=mysqli_fetch_assoc($wynik_zapytania2)){
			$obliczenie =$wiersz["cena"] * $liczba;
			print "wartość zakupów:".$obliczenie."zł";
			} 
			} 
			else{
			print "Brak wyników wyszuykiwania spełniających poszukiwane parametry";
			}
			}
			?>
		
		
		</form>
		
	</section>
	
	<section id="prawy">
		<h2>Kontakt</h2>
		<img src="zakupy2.png" alt="hurtownia">
		<p>email:
			<a href="mailto:hurt@poczta2.pl">hurt@poczta2.pl</a></p>
	</section>
	
	<section id="stopka">
		<h4>Witryne wykonał:04204024020402</h4>
	</section>


</body>
</html>
<?Php
mysqli_close($do_bazy)
?>