<!DOCTYPE html>
<html>
<head>
        <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
        <link rel="icon" href="favicon.ico" type="image/ico">
        <link rel="stylesheet" href="css/gaya.css">
        <title>CARI INFORMASI PROVINSI</title>
    </head>
    <body>
        <header>
            <h2><span>Informasi Provinsi</span></h2>
        </header>
        <article id="quiz_wrapper">
            <noscript>Anda harus menjalankan JavaScript di web browser Anda.</noscript>
        <div id="intro"><h2>Bagaimana caranya?</h2><p>Anda hanya memasukan Kode Provinsi! jika anda tidak tahu kode provinsi, anda bisa <a href="provinsi.php"> disini <a></p>
        </article>
        <?php
            if(isset($_POST['masuk'])){
$input_nik =  $_POST['input_nik'];
$server_location = "http://localhost/api_infonik/infonik/soap.php";
$options = array('trace' => true);
$client = new SoapClient("http://localhost/api_infonik/infonik/infonik.wsdl",array('location' => $server_location));
$result = $client->info_nik($input_nik);
if ($result=="Gagal"){
    echo "Input Gagal"; 
} else {

echo "<strong>Provinsi : </strong>".$result->provinsi."<br />";
echo "<strong>Ibu Kota : </strong>".$result->ibukota."<br />";
echo "<strong>Makanan Khas : </strong>".$result->wisatakuliner."<br />";
echo "<strong>Tempat Wisata : </strong>".$result->tempatwisata."<br />";
echo "<br />";
}
}
        ?>
        </div>
        <div>
        <form action="" method="POST">
        <h2>Pilih Provinsi : </h2><input placeholder="2 digit angka" id="input" name="input_nik">
        <button type="submit" name="masuk">Ayo Cek!</button>
        </form>
        </div>
        
</body>
</html>