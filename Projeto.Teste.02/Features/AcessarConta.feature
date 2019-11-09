#language: pt

Funcionalidade: Acessar Conta
	como um cliente cadastrado no sistema
	eu quero acessar minha conta
	de modo que eu possa realizar compras

	Cenário: Acesso realizado com sucesso
	Dado Acessar a página de login de cliente
	E Informar o email "lteixeira@muxi.com.br"
	E Informar a senha "123456"
	Quando Solciitar a realização do acesso
	Então Sistema exibe área restrita do cliente

	Cenário: Acesso Negado
	Dado Acessar a página de login de cliente
	E Informar o email "lteixeira@muxi.com.br"
	E Informar a senha "abcdef"
	Quando Solciitar a realização do acesso
	Então Sistema exibe mensagem "Usuário ou Senha Inválido."