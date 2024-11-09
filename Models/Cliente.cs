

﻿using System.ComponentModel.DataAnnotations;

namespace MinhaApi.model{
  public class Cliente{
    [Key]
    public int id_Cliente{get; private set;}
    public string Nome { get; private set;}
    public string Email { get; private set;}
    public string NumeroContato { get; private set;}
    public DateTime DataNascimento { get; private set;}

    public Cliente(string nome,string email, string numeroContato, DateTime dataNascimento ){
      this.Nome = nome;
      this.Email = email;
      this.NumeroContato= numeroContato;
      this.DataNascimento = dataNascimento;
    }

    public void Update(string nome, string email, string numeroContato, DateTime dataNascimento){
            Nome = nome;
            Email = email;
            NumeroContato = numeroContato;
            DataNascimento = dataNascimento;
    }
  } 
}
