<?php

class Infonik{

function kode_provinsi($i) {
    $i = intval($i);
    include 'db.php';
    // Buat prepared statement untuk mengambil semua data dari tbBiodata
    $query_provinsi = $db->prepare("SELECT * FROM provinsi WHERE kodeprovinsi='$i'");
    // Jalankan perintah SQL
    $query_provinsi->execute();
    // Ambil semua data dan masukkan ke variable $data
    $data = $query_provinsi->fetchAll();

    foreach ($data as $value): 
    //echo $value['nama_kotakabupaten'];

    if (isset($value['namaprovinsi'])) {
        return trim($value['namaprovinsi']);
        echo $value['namaprovinsi'];
    } 
    endforeach;
    return '<span class="error">Gagal</span>';
    }
function kota($i) {
    $i = intval($i);
    include 'db.php';
    // Buat prepared statement untuk mengambil semua data dari tbBiodata
    $query_kota = $db->prepare("SELECT * FROM provinsi WHERE kodeprovinsi='$i'");
    // Jalankan perintah SQL
    $query_kota->execute();
    // Ambil semua data dan masukkan ke variable $data
    $data = $query_kota->fetchAll();

    foreach ($data as $value): 
    //echo $value['nama_kotakabupaten'];

    if (isset($value['ibukota'])) {
        return trim($value['ibukota']);
        echo $value['ibukota'];
    } 
    endforeach;
    return '<span class="error">Gagal</span>';
    }
	
function kuliner($i) {
    $i = intval($i);
    include 'db.php';
    // Buat prepared statement untuk mengambil semua data dari tbBiodata
    $query_kuliner = $db->prepare("SELECT * FROM provinsi WHERE kodeprovinsi='$i'");
    // Jalankan perintah SQL
    $query_kuliner->execute();
    // Ambil semua data dan masukkan ke variable $data
    $data = $query_kuliner->fetchAll();

    foreach ($data as $value): 
    //echo $value['nama_kotakabupaten'];

    if (isset($value['wisatakuliner'])) {
        return trim($value['wisatakuliner']);
        echo $value['wisatakuliner'];
    } 
    endforeach;
    return '<span class="error">Gagal</span>';
    }
	
	function wisata($i) {
    $i = intval($i);
    include 'db.php';
    // Buat prepared statement untuk mengambil semua data dari tbBiodata
    $query_wisata = $db->prepare("SELECT * FROM provinsi WHERE kodeprovinsi='$i'");
    // Jalankan perintah SQL
    $query_wisata->execute();
    // Ambil semua data dan masukkan ke variable $data
    $data = $query_wisata->fetchAll();

    foreach ($data as $value): 
    //echo $value['nama_kotakabupaten'];

    if (isset($value['tempatwisata'])) {
        return trim($value['tempatwisata']);
        echo $value['tempatwisata'];
    } 
    endforeach;
    return '<span class="error">Gagal</span>';
    }
	
function info_nik($nik){
		if(strlen($nik) == 2){
			$hasil = "Berhasil";
		} else {
			$hasil = "Gagal";
		}
		$data = array();
        $data['provinsi']= substr($nik, 0, 2);
        $data['ibukota']= substr($nik, 0, 2);
        $data['wisatakuliner']= substr($nik, 0, 2);
		$data['tempatwisata']= substr($nik, 0, 2);
		$data_nik = new data_nik();
		$data_nik->provinsi =  $this->kode_provinsi($data['provinsi']);
		$data_nik->ibukota = $this->kota($data['ibukota']);
		$data_nik->wisatakuliner = $this->kuliner($data['wisatakuliner']);
		$data_nik->tempatwisata = $this->wisata($data['tempatwisata']);
		$data_nik->pesan = $hasil;
		
		if($hasil=="Berhasil"){
			return $data_nik;
		}
			return "Gagal";
	}
}


class data_nik{
	public $nik;
	public $provinsi;
	public $ibukota;
	public $wisatakuliner;
	public $tempatwisata;
	public $pesan;
}

$infonik_data = new Infonik;
$result = $infonik_data->info_nik($_GET['kode_provinsi']);
//$satu = json_encode($result, true));
//print_r($satu);
$data = json_encode((array)$result);
echo $data;
?>
