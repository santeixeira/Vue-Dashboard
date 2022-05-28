<template>
  <ListBox>
    <div class="input-boxes">
      <div class="title">
        <h1>Confira sua caixa de email!</h1>
      </div>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "@/components/Listas/ListBox.vue";
export default defineComponent({
  name: "MessageForgot",
  components: {
    ListBox
  }
});
</script>

<style lang="scss" scoped></style>
