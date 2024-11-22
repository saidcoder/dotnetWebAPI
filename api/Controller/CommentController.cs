using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [ApiController]
    [Route("api/comment")]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepo;

        public CommentController(IMapper mapper,ICommentRepository commentRepo)
        {
            _mapper = mapper;
            _commentRepo = commentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComment()
        {
            var comments = await _commentRepo.GetAll();
            var commentDto = _mapper.Map<List<CommentDto>>(comments);

            return Ok(commentDto);
        }
          
        
    }
}