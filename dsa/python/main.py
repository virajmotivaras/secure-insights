
def count_categories():
    categories = ["api", "db", "api", "security"]
    counts = {}
    for category in categories:
        counts[category] = counts.get(category, 0) + 1
    print(counts)
    



if __name__ == "__main__":
    print("Hello, DSA!")
    count_categories()