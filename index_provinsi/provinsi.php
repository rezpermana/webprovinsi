<!DOCTYPE html>
<html>
<head>
        <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
        <link rel="icon" href="favicon.ico" type="image/ico">
        <link rel="stylesheet" href="css/gaya.css">
    </head>
    <body>
        <header>
            <h2><span>Informasi Provinsi</span></h2>
        </header>
        <article id="quiz_wrapper">
            <noscript>Anda harus menjalankan JavaScript di web browser Anda.</noscript>
        <div id="intro"><h2>Bagaimana caranya?</h2><p>Anda hanya memasukan Kode Provinsi <a href="index.php">disini <a></p>
        </article>
        
        </div>
        <div class="container table-responsive">
		<table width="100%" id="lookup" class="table table-bordered table-hover table-striped">
                            <thead>
                                <tr> 
                                    <th>Kode Provinsi</th>
									<th>Nama Provinsi</th>
                                </tr>
                            </thead>
                            <tbody>
                                <?php
										include('db.php');
		
		//query ke database dg SELECT table siswa diurutkan berdasarkan NIS paling besar
		$query = mysql_query("SELECT * FROM provinsi ORDER BY kodeprovinsi ASC") or die(mysql_error());
		
		//cek, apakakah hasil query di atas mendapatkan hasil atau tidak (data kosong atau tidak)
		if(mysql_num_rows($query) == 0){	//ini artinya jika data hasil query di atas kosong
			
			//jika data kosong, maka akan menampilkan row kosong
			echo '<tr><td colspan="6">Tidak ada data!</td></tr>';
			
		}else{	//else ini artinya jika data hasil query ada (data diu database tidak kosong)
			
			//jika data tidak kosong, maka akan melakukan perulangan while
			$no = 1;	//membuat variabel $no untuk membuat nomor urut
			while($data = mysql_fetch_assoc($query)){	//perulangan while dg membuat variabel $data yang akan mengambil data di database
				
				//menampilkan row dengan data di database
				echo '<tr>';
					echo '<td>'.$data['kodeprovinsi'].'</td>';	//menampilkan data nis dari database
					echo '<td>'.$data['namaprovinsi'].'</td>';	//menampilkan data nama lengkap dari database			
				echo '</tr>';
				
				$no++;	//menambah jumlah nomor urut setiap row
				
			}
			
		}
                                ?>
                            </tbody>
                        
                        </table>
	</div>
        
</body>
</html>