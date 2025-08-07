<?php
try {
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        require_once __DIR__ . '/../../config/config.php';


        $date = $_POST['date'] ?? null;
        $activity = $_POST['activity'] ?? null;
        $duration = $_POST['duration'] ?? null;
        $intensity = $_POST['intensity'] ?? null;
        $notes = $_POST['notes'] ?? null;

        if (!$date || !$activity || !$duration || !$intensity) {
            throw new Exception("Missing required fields");
        }

        $stmt = $pdo->prepare("INSERT INTO activities (date, activity, duration, intensity, notes) VALUES (?, ?, ?, ?, ?)");
        $stmt->execute([$date, $activity, $duration, $intensity, $notes]);

        echo "Insert successful";
    }
} catch (Exception $e) {
    echo "Error: " . $e->getMessage();
}
exit;

?>