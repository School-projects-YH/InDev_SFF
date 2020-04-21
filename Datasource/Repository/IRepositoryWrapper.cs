using System;
using System.Collections.Generic;
using System.Text;

namespace SFF.Datasource.Repository
{
    public interface IRepositoryWrapper 
    {
        MoviePropertyRepository Movie { get; }
        MovieStudioRepository MovieStudio { get; }
        MovieTriviaRepository MovieTrivia { get; }
        void Save();
    }
}
