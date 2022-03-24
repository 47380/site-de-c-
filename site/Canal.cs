using System;

public class Canal : IComparable<Canal>{
  private string nome;
  public int Id { get; set; }
  public string Nome { get => nome; set => nome = value; }

  public int CompareTo(Canal obj){
    return this.nome.CompareTo(obj.nome);
  }

  public override string ToString(){
    return $"{Id} - {Nome}";
  }
}
