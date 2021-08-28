using System.Collections.Generic;
using TesteMazzaFC.Api.Notificacoes;

namespace TesteMazzaFC.Api.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}