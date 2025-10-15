<?php
$do_bazy= mysqli_connect('localhost','root','','sklep')

?>
<!DOCTYPE html>
<html lang="pl-PL">
<head>
<meta charset="utf-8">
<title>Sklep dla uczniów</title>
<link rel="stylesheet" href="styl.css">
</head>


<body>
<section id="baner">
		<h1>Dzisiejsze promocje naszego sklepu</h1>
 </section>

<section id="lewy">
		<h2>Taniej o 30%</h2>
		<?php
		$zapytanie="SELECT towary.nazwa from towary where towary.promocja='1';";
		print "<ol>";
		$wynik_zapytania=mysqli_query($do_bazy,$zapytanie);
		
		if(mysqli_num_rows($wynik_zapytania)>0){
		while($wiersz=mysqli_fetch_assoc($wynik_zapytania)){
		print "<li>";
		print $wiersz['nazwa'];
		print "</li>";
		}
		print "</ol>";
		}
		?>
 </section>

<section id="srodek">
		<h2>Sprawdź cenę</h2>
		<form action="sklep.php" method="POST">
		<select name="lista">
		<option>-</option>
		<option>Gumka do mazania</option>
		<option>Cienkopis</option>
		<option>Pisaki 60 szt.</option>
		<option>Markery 4 szt.</option>
		</select>
		<input type="submit" value="SPRAWDŹ">
		
		
		<section id="wynik"><?php
		if(isset($_POST['lista'])){
		$wybrano=$_POST['lista'];
		$zapytanie2="SELECT towary.cena FROM `towary` WHERE towary.nazwa='$wybrano';";
		
		$wynik_zapytania2 = mysqli_query($do_bazy,$zapytanie2); 
		
		if (mysqli_num_rows($wynik_zapytania2)>0){
		
		while($wiersz=mysqli_fetch_assoc($wynik_zapytania2)){
		print $wybrano."<br>";
		print "cena regularna:".$wiersz['cena']."<br>";
		print "cena promocyjna:".$wiersz['cena']*0.7."<br>";
		
		}
		} else {
		print "wybierz przedmiot z listy";
		}
		}
		?>
		</section>
		</form>
 </section>

<section id="prawy">
		<h2>Kontakt</h2>
		<p><a href="mailto:bok@sklep.pl">bok@sklep.pl</a></p>
		<img src="promocja.png" alt="promocja">
 </section>

<section id="stopka">
<h4>Autor strony:MAKSIU</h4>
 </section>

</body>




</html>
<?php
$z_bazy= mysqli_close($do_bazy)

?>