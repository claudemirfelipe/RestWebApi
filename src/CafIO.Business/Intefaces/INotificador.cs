using System.Collections.Generic;
using CafIO.Business.Notificacoes;

namespace CafIO.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}