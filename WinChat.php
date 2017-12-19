<?php

function db(){
	return mysqli_connect("localhost","root","password","WinChat");
}

$p = "";

if(isset($_GET['p'])){
		$p = $_GET['p'];
}else{
	header('Location: ?p=error&e=1');
}

if($p == "error"){
	if($_GET['e'] == "1"){
		echo "Page Error";
	}
	if($_GET['e'] == "2"){
		echo "Wrong Login Information";
	}
}

if($p == "auth"){
		$username = $_GET['username'];
		$password = $_GET['password'];
		$user = mysqli_query(db(),"SELECT * FROM users WHERE username='$username'");
		if(mysqli_num_rows($user) == null || mysqli_num_rows($user) == 0){
			echo json_encode(['ACK'=>'false','err'=>"Wrong Login Information"]);
			exit;
		}
		$user = mysqli_fetch_assoc($user);
		if($user['password'] != $password){
			echo json_encode(['ACK'=>'false','err'=>"Wrong Login Information"]);
			exit;
		}
		echo json_encode(['ACK'=>'true','id'=>$user['id'],'username'=>$username,'avatar'=>$user['avatar']]);
}

if($p == "allUsers"){
	$r = [];
	$q = mysqli_query(db(),"SELECT id,username FROM users ORDER BY id ASC");
	while($x = mysqli_fetch_assoc($q)){
		$r[]=$x;
	}
	echo json_encode($r);
}

if($p == "getChatHistory"){
	$r = [];
	$q = mysqli_query(db(),"SELECT * FROM messages ORDER BY id ASC");
	while($x = mysqli_fetch_assoc($q)){
		$msg = [];
		
		if (strpos($x['contents'],'_IMAGE_') !== false) {
			$msg = ['message'=>$x['contents']];
		}else{
			$msg = ['message'=>$x['user'].': '.$x['contents']];
		}
		$r[]=$msg;
	}
	echo json_encode($r);
}

if($p == "send"){
	$user = urldecode($_GET['user']);
	$message = urldecode($_GET['message']);
	error_log($message);
	mysqli_query(db(),"INSERT INTO messages (user,contents) VALUES ('$user','$message')");
}