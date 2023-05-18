#include <iostream>
#include <string>

struct EquipeEsports {
    std::string nome;
    int numeroCampeonatosVencidos;
    float valorTotalPremiacoes;
    int anoEstreia;
    
    void registrarCampeonatoVencido(float valorPremio) {
        numeroCampeonatosVencidos++;
        valorTotalPremiacoes += valorPremio;
    }
    
    void atualizarValorTotalPremiacoes(float valor) {
        valorTotalPremiacoes += valor;
    }
    
    bool verificarAnoEstreia() {
        int anoAtual = 2023; // Ano atual fictício
        return anoEstreia == anoAtual;
    }
    
    void imprimir() {
        std::cout << "Nome: " << nome << std::endl;
        std::cout << "Número de campeonatos vencidos: " << numeroCampeonatosVencidos << std::endl;
        std::cout << "Valor total de premiações: " << valorTotalPremiacoes << std::endl;
        std::cout << "Ano de estreia: " << anoEstreia << std::endl;
    }
};
