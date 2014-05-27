<?php
class Conexao {
    private $user;
    private $password;
    private $host;
    private $db_name;
 
    public function __construct() {
        $this->user     = 'i11857';
        $this->password = 'ByerbUt3';
        $this->host     = 'localhost';
        $this->db_name  = 'i11857';
    }
 
    public function connect() {
        return new PDO('mysql:host=' . $this->host  . ';dbname=' . $this->db_name, $this->user, $this->password);
    }
}


