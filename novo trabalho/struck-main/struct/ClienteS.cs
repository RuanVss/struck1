namespace Struct;

    public struct ClienteS{

    public string nome;
    public string cpf;
    public string dataNasc;
    public string email;

         public ClienteS(string nome, string cpf, string dataNasc, string email){
        this.nome = nome;
        this.cpf = cpf;
        this.dataNasc = dataNasc;
        this.email = email;
          }

        public string imprimir(){
        return "\nNome:  " + this.nome +
           "\nCpf:  " + this.cpf +
            "\nData de nacismento:  " + this.dataNasc +
             "\nEmail:  " + this.email;
        }

}