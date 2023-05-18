#include <iostream>
#include <string>

struct Produto {
    std::string nome;
    int quantidadeEmEstoque;
    float valor;
    
    void aplicarCupomDescontoValor(float desconto) {
        valor -= desconto;
    }
    
    void aplicarCupomDescontoPorcentagem(float descontoPorcentagem) {
        valor -= valor * descontoPorcentagem / 100.0;
    }
    
    void verificarQuantidadeEmEstoque() {
        if (quantidadeEmEstoque > 0) {
            std::cout << "O produto está em estoque." << std::endl;
        } else {
            std::cout << "O produto está indisponível no estoque." << std::endl;
        }
    }
    
    void imprimir() {
        std::cout << "Nome: " << nome << std::endl;
        std::cout << "Quantidade em estoque: " << quantidadeEmEstoque << std::endl;
        std::cout << "Valor: " << valor << std::endl;
    }
};
