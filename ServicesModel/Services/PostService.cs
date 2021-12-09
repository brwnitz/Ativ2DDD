using AutoMapper;
using DomainModels.Interfaces;
using ServicesModel.Interfaces;
using ServicesModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModel.Services
{
    public class PostService : IPostService
    {
        private IPostRepository _postRepository;

        private readonly IMapper _mapper;
        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public IEnumerable<PostViewModel> GetPost()
        {
            var post = _postRepository.GetPost();
            return _mapper.Map<IEnumerable<PostViewModel>>(post);
        }
    }
}
