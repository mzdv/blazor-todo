using BlazorToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDo.Services
{
    public class CardModelService
    {
        private List<CardModel> cards = new List<CardModel>()
        {
            new CardModel
            {
                Id = 0,
                Title = "Feed the chickens",
                Content = "They get hungry",
                Done = false
            },
            new CardModel
            {
                Id = 1,
                Title = "Water your plants",
                Content = "Lush green pineapples",
                Done = true
            },
            new CardModel
            {
                Id = 2,
                Title = "Get food",
                Content = "Pizza should be fine",
                Done = false
            },
            new CardModel
            {
                Id = 3,
                Title = "Wash the dishes",
                Content = "Otherwise you'll eat from the floor",
                Done = false
            },
        };

        public Task<List<CardModel>> GetCards()
        {
            Task<List<CardModel>> result = null;

            try
            {
                result = Task.FromResult(cards);
            }
            catch
            {
            }

            return result;
        }

        public bool DeleteCard(int id)
        {
            bool result = false;

            try
            {
                cards.RemoveAll(c => c.Id == id);
                result = true;
            }
            catch
            {
            }

            return result;
        }
    }
}
