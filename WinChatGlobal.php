<?php

function db(){
	return mysqli_connect("localhost","root","password","WinChat");
}

$p = "";

if(isset($_GET['p'])){
		$p = $_GET['p'];
}

if($p == "getServerList"){
	$r = [];
	$q = mysqli_query(db(),"SELECT name,addr,motd,owner FROM list_global ORDER BY id ASC");
	while($x = mysqli_fetch_assoc($q)){
		$r[]=$x;
	}
	echo json_encode($r);
}