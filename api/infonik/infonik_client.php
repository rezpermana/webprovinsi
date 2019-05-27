<?php

$server_location = "http://localhost/api_infonik/infonik/infonik.php";
$client = new SoapClient("http://localhost/api_infonik/infonik/infonik.wsdl",array('location' => $server_location));

echo "<h2>Hasil</h2><pre>";
$result = $client->info_nik('');
//$result = $client->info_nik('3207013012950004');
//var_dump($result);
if ($result=="Gagal"){
	echo "Input Gagal"; 
} else {
	//$satu = json_encode($result, true);
	print_r($result);
	//$satu = json_decode(json_encode($result, true));
	//print_r($satu);
//$dua = json_encode($result);
echo "<br />";
echo "NIK : ".$result->nik."<br />";
echo "Provinsi : ".$result->provinsi."<br />";
echo "Ibu Kota : ".$result->ibukota."<br />";
echo "Wisata Kuliner : ".$result->wisatakuliner."<br />";
echo "Tempat Wisata : ".$result->tempatwisata."<br />";
echo "Pesan (Status) : ".$result->pesan."<br />";


echo "<br>";
echo "</pre>";
}


?>

