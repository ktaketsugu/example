public int calculatePoints(String membershipType, int purchaseAmount) {
    int points = 0;

    if (membershipType.equals("Gold")) {
        if (purchaseAmount >= 1000) {
            points = (int) Math.floor(purchaseAmount / 10);
        } else if (purchaseAmount >= 500) {
            points = (int) Math.floor(purchaseAmount / 20);
        } else {
            points = (int) Math.floor(purchaseAmount / 30);
        }
    } else if (membershipType.equals("Silver")) {
        if (purchaseAmount >= 2000) {
            points = (int) Math.floor(purchaseAmount / 8);
        } else {
            points = (int) Math.floor(purchaseAmount / 15);
        }
    } else if (membershipType.equals("Bronze")) {
        if (purchaseAmount >= 1500) {
            points = (int) Math.floor(purchaseAmount / 6);
        } else {
            points = (int) Math.floor(purchaseAmount / 10);
        }
    }

    return points;
}
