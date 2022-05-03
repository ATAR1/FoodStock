using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStock.Common.Commands
{
    /// <summary>
    /// Команда открыть справочник
    /// </summary>
    public class OpenHandbookCommand
    {
        private IHandbooksRepository _repository;
        private IHandbooksPresenter _presenter;

        public OpenHandbookCommand(IHandbooksRepository handbooksRepository, IHandbooksPresenter presenter)
        {
            this._repository = handbooksRepository;
            this._presenter = presenter;
        }

        public void Execute()
        {
            _presenter.Show(_repository.GetHandbook());
        }
    }
}
