<template>
  <div class="is-flex">
    <label for="txtSalary" class="checkbox">
      <input type="checkbox" />
      <slot></slot>
    </label>
  </div>
  <div class="is-flex">
    <div class="field mt-2">
      <div class="control has-icons-left">
        <input
          id="txtSalary"
          class="input"
          type="text"
          placeholder="Digite o valor"
        />
        <span class="icon is-left">
          <i class="fas fa-dollar"></i>
        </span>
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "TextSalaryRegister",
});
</script>

<style scoped></style>
