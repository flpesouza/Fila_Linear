using System;
class Fila
{
    private string[] array;
    private int primeiro;
    private int ultimo;
    /**
    * Construtor da classe.
*/
    public Fila(int tamanho)
    {
        array = new string[tamanho + 1];
        primeiro = ultimo = 0;
    }
    /**
    * Insere um elemento na ultima posicao da fila.
*/
    public void Inserir(string x)
    {
        if (((ultimo + 1) % array.Length) == primeiro)
        {
            throw new Exception("Erro");
        }
        array[ultimo] = x;
        ultimo = (ultimo + 1) % array.Length;
    }
    /**
    * Remove um elemento da primeira posicao da fila e movimenta
    * os demais elementos para o primeiro da mesma.
*/
    public string Remover()
    {
        if (primeiro == ultimo)
        {
            throw new Exception("Erro");
        }
        string resp = array[primeiro];
        primeiro = (primeiro + 1) % array.Length;
        return resp;
    }
    /**
    * Mostra os elementos da fila separados por espacos.
*/
    public void Mostrar()
    {
        int i = primeiro;
        Console.Write("[");
        while (i != ultimo)
        {
            Console.Write(array[i] + " ");
            i = (i + 1) % array.Length;
        }
        Console.WriteLine("]");
    }

    public int ObterTamanho()
    {
        int i = primeiro;
        int cont = 0;
        while (i != ultimo)
        {
            cont++;
            i = (i + 1) % array.Length;
        }
        return cont;
    }

    public string ObterPrimeiro()
    {
        return array[primeiro];
    }
}