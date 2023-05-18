#include <iostream>
#include <string>

struct JogadorFutebol {
    std::string nome;
    int numeroCartoesAmarelos;
    int numeroCartoesVermelhos;
    std::string clubeVinculado;
    
    void registrarNumeroCartoesAmarelos() {
        numeroCartoesAmarelos++;
    }
    
    void registrarNumeroCartoesVermelhos() {
        numeroCartoesVermelhos++;
    }
    
    bool verificarVinculoClube() {
        return !clubeVinculado.empty();
    }
    
    void imprimir() {
        std::cout << "Nome: " << nome << std::endl;
        std::cout << "Número de cartões amarelos: " << numeroCartoesAmarelos << std::endl;
        std::cout << "Número de cartões vermelhos: " << numeroCartoesVermelhos << std::endl;
        std::cout << "Clube vinculado: " << clubeVinculado << std::endl;
    }
};
