// Solicita ao usuário que insira o nome do personagem:
const nomePersonagem = gets();

// Solicita ao usuário que escolha entre "Atacar" ou "Fugir":
const acaoEscolhida = gets();

// Implementado uma solução utilizando lógica de programação;
// Verificado a ação escolhida e exibir a mensagem correspondente:

function combate() {
  if (acaoEscolhida === 'Fugir') {
    return `${nomePersonagem} escolheu Fugir!`;
  } else if (acaoEscolhida === 'Atacar'){
    return `${nomePersonagem} escolheu Atacar!`;
  }else
    return 'Tente novamente';
}

var resultado = combate();
print(resultado);
