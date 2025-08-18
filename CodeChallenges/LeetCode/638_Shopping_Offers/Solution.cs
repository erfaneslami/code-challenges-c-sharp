namespace CodeChallenges.LeetCode._638_Shopping_Offers;

public class Solution {
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        var result = DFS(price, special, needs, 0, 0);
        return result;
    }

    private int DFS(IList<int> price,IList<IList<int>> special, IList<int> needs, int curr, int min)
    {
        var currentOffer = special[curr];
        var normalPrice = 0;

        for (int i = 0; i < needs.Count; i++)
        {
            normalPrice += needs[i] * price[i];
        }

        for (int i = 0; i < special.Count; i++)
        {
            var offer = special[i];
            var canPurchase = true;
            var newNeeds = new List<int>(needs);
            
            for (int j = 0; j < needs.Count; j++)
            {
                if (offer[j] > needs[j])
                {
                    canPurchase = false;
                    break;
                }

                newNeeds[j] -= offer[j];
            }

            if (canPurchase)
            {
                var priceWithOffer = DFS(price,special, newNeeds,i, offer[needs.Count] + min);
                return Math.Min(normalPrice, priceWithOffer);
            }
        }
        return min;
    }
}