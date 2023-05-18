#include <iostream>
#include <string>

struct Professor {
    std::string nome;
    float salario;
    int cargaHoraria;
    
    void reajusteSalarialEmValor(float valor) {
        salario += valor;
    }
    
    void reajusteSalarialEmPorcentagem(float taxa) {
        salario += salario * taxa / 100.0;
    }
    
    void descontoSalarialPorFaltaEmValor(float valor) {
        salario -= valor;
    }
    
    void descontoSalarialPorFaltaEmPorcentagem(float taxa) {
        salario -= salario * taxa / 100.0;
    }
    
    void aumentarCargaHorariaDeTrabalho(int horas) {
        cargaHoraria += horas;
        // Realizar o reajuste salarial de acordo com a carga horária
    }
    
    void imprimir() {
        std::cout << "Nome: " << nome << std::endl;
        std::cout << "Salário: " << salario << std::endl;
        std::cout << "Carga horária de trabalho: " << cargaHoraria << std::endl;
    }
};
