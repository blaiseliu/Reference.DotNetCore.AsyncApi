﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Reference.DotNetCore.AsyncApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController:ControllerBase
    {
        private readonly ILogger<NotesController> _logger;

        private static readonly string[] Notes = {
            "1. Dont't worry if it doesn't work right.If everything did, you'd be out of a job.",
            "2.  Don't comment bad code - rewrite it. - Brian Kernighan",
            "3.  A programming language is for thinking about programs, not for expressing programs you've already thought of. It should be a pencil, not a pen. - Paul Graham",
            "4.  Sometimes it pays to stay in bed on Monday, rather than spending the rest of the week debugging Monday's code. - Dan Salomon",
            "5.  It´s better to wait for a productive programmer to become available than it is to wait for the first available programmer to become productive. - Steve McConnell",
            "6.  One of my most productive days was throwing away 1000 lines of code. Ken Thompson",
            "7.  Without requirements or design, programming is the art of adding bugs to an empty text file.",
            "8.  One main'scrappy software is another man's full time job.",
            "9.  Walking on water and developing software from a specification are easy if both are frozen.",
            "10.  Debugging is twice as hard as writing the code in the first place.Therfore, if you write the code as cleverly as possible, you are, by definition, not smart enough to debug it. - Rajanand",
            "11.  System programmers are the high priests of a low cult. - Robert S. Barton",
            "12.  I don't care if it works on your machine! We are not shipping your machine! - Vidiu Platon",
            "13.  Software undergoes beta testing shortly before iy' released.Beta is latin for \"still doesn't work\"",
            "14.  Measuring programming progree by lines of code is like measuring aircraft building progree by weight. - Bill Gates",
            "15.  If debudding is the process of removing software bugs, then programming must be the process of putting them in. - Edsger W. Dijkstra",
            "16.  The computer was born to solve problems that did not exist before. - Bill Gates",
            "17.  Real programmers don't comment their code. If it was hard to write, it should be hard to understand.",
            "18.  Always code as if the guy who ends up maintaning your code will be a violent psychopath who knows where you live. - Rick Osborne",
            "19.  People don't care about what you say, they care about what you build. - Mark Zuckerberg",
            "20.  We have to stop optimizing for programmers and start optimizing for users. — Jeff Atwood",
            "21.  If the code and the comments do not match, possibly both are incorrect. — Norm Schryer",
            "22.  Bad programmers worry about the code. Good programmers worry about data structures and their relationships. - Linus Torvalds",
            "23.  If you optimize everything, you will always be unhappy. - Donald Knuth",
            "24.  Your mind is programmable - if you're not programming your mind, else will program it for you. - Jeremy Hammond",
            "25.  The trouble with programmers is that you can never tell what a programmer is doing until it's too late. - 	Seymour Cray",
            "26.  Debugging becomes significantly easier if you first admit that you are the problem. - William Laeder",
            "27.  Talk is cheap.Show me the code. - Linus Torvalds",
            "28.  Everybody in this country should learn to program a computer because it teaches you how to think. - Steve Jobs",
            "29.  Most good programmers do programming not because they expect to get paid or get adulation by the public, but because it is fun to program. - Rajanand",
            "30.  Any fool can write code that a computer can understand.Good programmers write code that humans can understand.",
            "31.  First, solve the problem.Then write the code. - John Johnson",
            "32.  The function of a good software is to make the complex appear to be simple. - Grady Booch",
            "33.  Your most unhappy customers are your greatest source of learning. — Bill Gates",
            "34.  Small minds are concerned with the extraordinary, great minds with the ordinary. - Blaise Pascal",
            "35.  Everyday life is like programming, I guess.If you love something you can put beauty on it. - Donald Knuth",
            "36.  You are not responsible for the programming you picked up in childhood.However, as an adult, you are the one hundred percent responsible for fixing it.",
            "37.  Developer is an organism that turns coffee into code.",
            "38.  The purpose of software engineering is to control complexity, not to create it.",
            "39.  As a programmer, it is your job to put yourself out of business. What you do today can be automated tomorrow. - Doug McIlroy",
            "40.  A good programmer is someone who always looks both ways before crossing a one-way street. - Doug Linder",
            "41.  Testing can only prove the presence of bugs, not their absence. – Edsger W. Dijkstra",
        };

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Notes;
        }
    }
}
